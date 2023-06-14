using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Services.Maps;

namespace Proyecto_fisica.screen.utils.caidaLibre
{
    public class CalculadoraCaidaLibre
    {
        public double gravedad { set; get; }
        public string altura { set; get; }
        public string tiempo { set; get; }
        public string velocidadFinal { set; get; }
        public string velocidadInicial { set; get; }
        public string velocidadMedia { set; get; }

        public List<FormularioCaidaLibreModel> formularioCaidaLibre { set; get; }

        public String message = "No se puede calcular faltan datos";


        public String[] getResultCalculation(int cal) {
           
            formularioCaidaLibre = new List<FormularioCaidaLibreModel>();
            switch (cal)
            {
                case 0:
                    return setCalculateAltura(tiempo, velocidadFinal, velocidadInicial, velocidadMedia);
                case 1:
                    return setCalculateTiempo(altura, velocidadFinal, velocidadInicial, velocidadMedia);
                case 2:
                    return setCalculateVelocidadFinal(tiempo, altura, velocidadInicial,velocidadMedia);
                case 3:
                    return setCalculateVelocidadInicial(tiempo, altura, velocidadFinal, velocidadMedia);
                case 4:
                    return setCalculateVelocidadMedia(velocidadFinal, velocidadInicial, tiempo, altura);
                default:
                    return new String[0];
            }
        }

        private String[] setCalculateTiempo(string h, string vf, string vo,string vm) {
            String[] result = new string[1];
            result[0] = "";
            double cal = 0;


            if (isEmpty(h) && !isEmpty(vf) && !isEmpty(vo) && isEmptyNotExplicit(vm))
            {
                // t = (vf - vo)/g
                cal = (parDouble(vf) - parDouble(vo)) / gravedad;
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("t", cal.ToString(), "s", "(vf - vo)/g"));
                result[0] = cal.ToString();
            }
            else if (!isEmpty(h) && isEmpty(vf) && isEmpty(vo) && isEmptyNotExplicit(vm))
            {
                // t = raiz((2 * h)/g)
                cal = (2 * parDouble(h)) / gravedad;
                cal = Math.Sqrt(cal);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("t", cal.ToString(), "s", "raiz((2 * h)/g)"));
                result[0] = cal.ToString();
            }
            else if (!isEmpty(h) && !isEmpty(vf) && isEmpty(vo) && isEmptyNotExplicit(vm))
            {
                cal = (2 * gravedad * parDouble(h)) - poten2(vf);
                if (cal.ToString().Contains("-"))
                {
                    result[0] = message;
                }
                else
                {
                    // vo = raiz(2gy+vf^2)
                    cal = Math.Sqrt(cal);
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "raiz(2*g*y+vf^2)"));
                    // t = (vf - vo)/g
                    cal = (parDouble(vf) - cal) / gravedad;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("t", cal.ToString(), "s", "(vf - vo)/g"));
                    result[0] = cal.ToString();
                }

            }
            else if (!isEmpty(h) && isEmpty(vf) && !isEmpty(vo) && isEmptyNotExplicit(vm))
            {
                // vf = raiz(2gy+vo^2)
                cal = Math.Sqrt((2 * gravedad * parDouble(h)) + poten2(vo));
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "raiz(2*g*y+vo^2)"));
                // t = (vf - vo)/g
                cal = ( cal - parDouble(vo)) / gravedad;
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("t", cal.ToString(), "s", "(vf - vo)/g"));
                result[0] = cal.ToString();

            }
            else if (!isEmpty(vf) && !isEmpty(vo) && isEmptyNotExplicit(h) && isEmptyNotExplicit(vm))
            {
                // t = (vf - vo)/g
                cal = (parDouble(vf) - parDouble(vo)) / gravedad;
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("t", cal.ToString(), "s", "(vf - vo)/g"));
                result[0] = cal.ToString();
            }

            else
            {
                if (!isEmpty(vf) && isEmpty(vo) && !isEmpty(vm))
                {
                    // vo = (vm * 2 - vf)
                    cal = ((parDouble(vm) * 2) - parDouble(vf));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "(vm * 2 - vf)"));
                    // t = (vf - vo)/g
                    cal = ((parDouble(vf) - cal)) / gravedad;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("t", cal.ToString(), "s", "(vf - vo)/g"));
                    result[0] = cal.ToString();
                }
                else if (isEmpty(vf) && !isEmpty(vo) && !isEmpty(vm))
                {
                    // vf = vm * 2 - vo
                    cal = parDouble(vm) * 2 - parDouble(vo);
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "vm * 2 - vo"));
                    // t = (vf - vo)/g
                    cal = (cal - parDouble(vo)) / gravedad;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("t", cal.ToString(), "s", "(vf - vo)/g"));
                    result[0] = cal.ToString();
                }
                else if (!isEmpty(h) && isEmpty(vf) && isEmpty(vo) && !isEmpty(vm))
                {
                    string velFi = setCalculateVelocidadFinal("", h, "", vm)[0];
                    string velIn = setCalculateVelocidadInicial("", h, "", vm)[0];

                    if (!isEqualsMessage(velFi) && !isEqualsMessage(velIn))
                    {
                        // t = (vf - vo)/g
                        cal = (parDouble(velFi) - parDouble(velIn)) / gravedad;
                        formularioCaidaLibre.Add(new FormularioCaidaLibreModel("t", cal.ToString(), "s", "(vf - vo)/g"));
                        result[0] = cal.ToString();
                    }
                    else
                    {
                        result[0] = message;
                    }

                } else {
                    result[0] = message;
                }
                
            }
            return result;
        }

        private String[] setCalculateAltura(string t, string vf, string vo,string vm)
        {
            String[] result = new string[1];
            double cal = 0;


            if (!isEmpty(t) && !isEmpty(vo) && isEmpty(vf))
            {
                // y = vo * t + 1/2 * gt^2
                cal = (parDouble(vo) * parDouble(t)) + (0.5 * gravedad * (parDouble(t) * parDouble(t)));
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("h",cal.ToString(),"m", "vo * t + 1/2 * gt^2"));

                result[0] = cal.ToString();
            }
            else if (!isEmpty(t) && !isEmpty(vf))
            {
                // y = vf * t - 1/2 * gt^2
                cal = (parDouble(vf) * parDouble(t)) - (0.5 * gravedad * (parDouble(t) * parDouble(t)));
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("h", cal.ToString(), "m", "vf * t - 1/2 * gt^2"));
                result[0] = cal.ToString();

            }
            else if (!isEmpty(t) && !isEmpty(vf) && !isEmpty(vo))
            {
                // y = ((vf + vo)/2)/t
                cal = ((parDouble(vf) + parDouble(vo)) / 2) / parDouble(t);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("h", cal.ToString(), "m", " ((vf + vo)/2)/t"));
                result[0] = cal.ToString();
            }
            else if (isEmpty(t) && !isEmpty(vf) && !isEmpty(vo))
            {
                // y = ((vf^2 - vo^2)/2 * g)
                cal = (poten2(vf) - poten2(vo)) / (2 * gravedad);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("h", cal.ToString(), "m", "(vf^2 - vo^2)/2 * g"));
                result[0] = cal.ToString();
            }
            else {
                if (!isEmpty(t) && isEmpty(vf) && isEmpty(vo) && !isEmpty(vm))
                {
                    // vo = (vm * 2 - gt)/2
                    cal = ((parDouble(vm) * 2) - (gravedad * parDouble(t))) / 2;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "(vm * 2 - gt)/2"));
                    // vf = vm * 2 - vo
                    cal = ((parDouble(vm) * 2) - (cal));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "vm * 2 - vo"));
                    // y = vf * t - 1/2 * gt^2
                    cal = (cal * parDouble(t)) - (0.5 * gravedad * poten2(t));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("y", cal.ToString(), "m", "vf * t - 1/2 * gt^2"));
                    result[0] = cal.ToString();
                }
                else if (isEmpty(t) && !isEmpty(vf) && isEmpty(vo) && !isEmpty(vm))
                {
                    // vo = (vm * 2 - vf)
                    cal = ((parDouble(vm) * 2) - parDouble(vf));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "(vm * 2 - vf)"));
                    // y = ((vf^2 - vo^2)/2 * g)
                    cal = (poten2(vf) - poten2(cal.ToString())) / (2 * gravedad);
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("y", cal.ToString(), "m", "(vf^2 - vo^2)/(2 * g)"));
                    result[0] = cal.ToString();
                }
                else if (isEmpty(t) && isEmpty(vf) && !isEmpty(vo) && !isEmpty(vm))
                {
                    // vf = (vm * 2 - vo)
                    cal = ((parDouble(vm) * 2) - parDouble(vo));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "vm * 2 - vo"));
                    // y = ((vf^2 - vo^2)/2 * g)
                    cal = (poten2(cal.ToString()) - poten2(vo)) / (2 * gravedad);
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("y", cal.ToString(), "m", "(vf^2 - vo^2)/(2 * g)"));
                    result[0] = cal.ToString();
                }
                else {
                    result[0] = message;
                }
                
            }

            return result;
        }

        private String[] setCalculateVelocidadFinal(string t, string h, string vo,string vm)
        {
            String[] result = new string[1];
            double cal = 0;


            if (isEmpty(h) && !isEmpty(vo) && !isEmpty(t))
            {
                // vf = vo + gt
                cal = (parDouble(vo)) + (gravedad * parDouble(t));
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "vo + gt"));
                result[0] = cal.ToString();
            }
            else if (!isEmpty(h) && !isEmpty(vo) && isEmpty(t))
            {
                // vf =  raiz(2*g*h + vo^2)
                cal = (2 * gravedad * parDouble(h)) + poten2(vo);
                cal = Math.Sqrt(cal);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "raiz(2*g*h + vo^2)"));
                result[0] = cal.ToString();
            }
            else if (isEmpty(h) && isEmpty(t) && !isEmpty(vo) && !isEmpty(vm))
            {
                // vf =  2*vm - vo
                cal = (2 * parDouble(vm)) - parDouble(vo);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "2*vm - vo"));
                result[0] = cal.ToString();
            }
            else if (!isEmpty(h) && !isEmpty(t) && isEmptyNotExplicit(vo) && isEmptyNotExplicit(vm))
            {
                // vf =  (y/t) + (gt/2)
                cal = (parDouble(h)/ parDouble(t)) + ((gravedad * parDouble(t))/2);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "(y/t) + (gt/2)"));
                result[0] = cal.ToString();
            }

            else
            {
                if (!isEmpty(h) && isEmpty(t) && isEmpty(vo) && !isEmpty(vm))
                {
                    // vo = ( -gy/2vm) + vm
                    cal = (-gravedad * parDouble(h) / (2 * parDouble(vm))) + parDouble(vm);
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "( -gy/2vm) + vm"));
                    // vf = vm * 2 - vo
                    cal = parDouble(vm) * 2 - cal;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "vm * 2 - vo"));
                    result[0] = cal.ToString();
                } 
                else if(isEmpty(h) && !isEmpty(t) && isEmpty(vo) && !isEmpty(vm))
                {
                    // vo = (vm) + (gt/2)
                    cal = (parDouble(vm) + ((gravedad * parDouble(t)) / 2));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "(vm) + (gt/2)"));
                    // vf = vm * 2 - vo
                    cal = parDouble(vm) * 2 - cal;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "vm * 2 - vo"));
                    result[0] = cal.ToString();
                }
                else if (isEmpty(h) && isEmpty(t) && !isEmpty(vo) && !isEmpty(vm))
                {
                    // vf = vm * 2 - vo
                    cal = parDouble(vm) * 2 - parDouble(vo);
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "vm * 2 - vo"));
                    result[0] = cal.ToString();
                }
                else {
                    result[0] = message;
                }
                
            }

            return result;
        }

        private String[] setCalculateVelocidadInicial(string t, string h, string vf, string vm)
        {
            String[] result = new string[1];
            double cal = 0;

           if ( !isEmpty(t) && !isEmpty(vf) && isEmpty(h) && isEmpty(vm))
            {
                // vo =  (vf)-(g*t)
                cal = (parDouble(vf) - (gravedad * (parDouble(t))));
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "(vf)-(g*t)"));
                result[0] = cal.ToString();
            }
            else if (!isEmpty(vf) && !isEmpty(vm) && isEmpty(h) && isEmpty(t))
            {
                // vo =  2*vm - vf
                cal = (2 * parDouble(vm)) - parDouble(vf);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "2*vm - vf"));
                result[0] = cal.ToString();
            }
            else if (!isEmpty(h) && !isEmpty(vf) && isEmpty(t) && isEmpty(vm))
            {
                // vo =  raiz(vf^2 - 2gh)
                cal = poten2(vf) - (2 * gravedad * parDouble(h));
                cal = Math.Sqrt(cal);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "raiz(vf^2 - 2gh)"));
                result[0] = cal.ToString();
            }
            else if (!isEmpty(h) && !isEmpty(t) && isEmptyNotExplicit(vf) && isEmptyNotExplicit(vm))
            {
                // vo =  (y/t) - (gt/2)
                cal = (parDouble(h) / parDouble(t)) - ((gravedad * parDouble(t)) / 2);
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "(y/t) - (gt/2)"));
                result[0] = cal.ToString();
            }

            else
            {
                if (!isEmpty(h) && isEmpty(t) && isEmpty(vf) && !isEmpty(vm))
                {
                    cal = -poten2(vm) + (gravedad * parDouble(h));
                    if (cal.ToString().Contains("-"))
                    {
                        result[0] = message;
                    } else {
                        // vf = vm + raiz(-vm^2 + gy)
                        cal = parDouble(vm) + Math.Sqrt(cal);
                        formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "vm + raiz(-vm^2 + gy)"));
                        // vo = vm * 2 - vf
                        cal = parDouble(vm) * 2 - cal;
                        formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "vm * 2 - vf"));
                        result[0] = cal.ToString();
                    }
                   
                }
                else if (isEmpty(h) && !isEmpty(t) && isEmpty(vf) && !isEmpty(vm))
                {
                    // vo = (vm) + (gt/2)
                    cal = (parDouble(vm) + ((gravedad * parDouble(t)) / 2));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "(vm) + (gt/2)"));
                    result[0] = cal.ToString();
                }
                else if (isEmpty(h) && isEmpty(t) && !isEmpty(vf) && !isEmpty(vm))
                {
                    // vo = vm * 2 - vf
                    cal = parDouble(vm) * 2 - parDouble(vf);
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "vm * 2 - vf"));
                    result[0] = cal.ToString();
                }
                else
                {
                    result[0] = message;
                }
            }

            return result;
        }

        private String[] setCalculateVelocidadMedia(string vf, string vo, string t, string h)
        {
            String[] result = new string[1];
            double cal = 0;

            if (!isEmpty(vf) && !isEmpty(vo))
            {
                // vm = (vf + vo)/2
                cal = (parDouble(vf) + parDouble(vo))/2;
                formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vm", cal.ToString(), "m/s", "(vf + vo)/2"));
                result[0] = cal.ToString();
            }
            else
            {
                if (!isEmpty(vf) && !isEmpty(t) && isEmpty(vo))
                {
                    // vo = (vf - gt)
                    cal = parDouble(vf) - (gravedad * parDouble(t));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "(vf - gt)"));

                    // vm = (vf + vo)/2
                    cal = (parDouble(vf) + cal) / 2;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vm", cal.ToString(), "m/s", "(vf + vo)/2"));
                    result[0] = cal.ToString();
                }
                else if (!isEmpty(vo) && !isEmpty(t) && isEmpty(vf))
                {
                    // vf = (vo + gt)
                    cal = parDouble(vo) + (gravedad * parDouble(t));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "(vo + gt)"));

                    // vm = (vf + vo)/2
                    cal = (parDouble(vo) + cal) / 2;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vm", cal.ToString(), "m/s", "(vf + vo)/2"));
                    result[0] = cal.ToString();
                }
                else if (!isEmpty(vo) && !isEmpty(h) && isEmpty(vf))
                {
                    // vf = raiz(2gy+vo^2)
                    cal = Math.Sqrt((2 * gravedad * parDouble(h)) + poten2(vo));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "raiz(2gy+vo^2)"));
                    // vm = (vf + vo)/2
                    cal = (parDouble(vo) + cal) / 2;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vm", cal.ToString(), "m/s", "(vf + vo)/2"));
                    result[0] = cal.ToString();
                }
                else if (!isEmpty(vf) && !isEmpty(h) && isEmpty(vo))
                {
                    cal = (2 * gravedad * parDouble(h)) - poten2(vf);
                    if (cal.ToString().Contains("-"))
                    {
                        result[0] = message;
                    }
                    else
                    {
                        // vo = raiz(2gy+vf^2)
                        cal = Math.Sqrt(cal);
                        formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", "raiz(2gy+vf^2)"));
                        // vm = (vf + vo)/2
                        cal = (parDouble(vf) + cal) / 2;
                        formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vm", cal.ToString(), "m/s", "(vf + vo)/2"));
                        result[0] = cal.ToString();
                    }
                }
                else if (!isEmpty(t) && !isEmpty(h) && isEmpty(vo) && isEmpty(vf))
                {
                    // vf =  (y/t) + (gt/2)
                    cal = (parDouble(h) / parDouble(t)) + ((gravedad * parDouble(t)) / 2);
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vf", cal.ToString(), "m/s", "(y/t) + (gt/2)"));
                    // vo =  (y/t) - (gt/2)
                    cal = cal + ((parDouble(h) / parDouble(t)) - ((gravedad * parDouble(t)) / 2));
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vo", cal.ToString(), "m/s", " (y/t) - (gt/2)"));
                    // vm = (vf + vo)/2
                    cal = (cal) / 2;
                    formularioCaidaLibre.Add(new FormularioCaidaLibreModel("vm", cal.ToString(), "m/s", "(vf + vo)/2"));
                    result[0] = cal.ToString();

                }
                else {
                    result[0] = message;
                }   
                
            }

            return result;
        }

        private bool isEmpty(String v) {
            return v.Trim().Equals("");
        }

        private bool isEqualsMessage(String v)
        {
            return v.Trim().Equals(message);
        }

        private bool isEmptyNotExplicit(String v)
        {
            if (v.Trim().Equals("") || !v.Trim().Equals(""))
            {
                return true;
            }
            return false;
        }

        private double poten2(String v) {
            return parDouble(v) * parDouble(v);
        }
        private double parDouble(String v)
        {
            return v != null && !isEmpty(v) ? Double.Parse(v): 0;
        }
    }
}
