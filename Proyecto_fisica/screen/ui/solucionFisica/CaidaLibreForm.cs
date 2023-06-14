using ControlComponents.Component.Inputs;
using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.utils.caidaLibre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fisica.screen.ui.solucionFisica
{
    public partial class CaidaLibreForm : BaseForms
    {
        private CalculadoraCaidaLibre caluLibre;
        private int numSelect = -1;
        public CaidaLibreForm()
        {
            InitializeComponent();
        }

        private void CaidaLibreForm_Load(object sender, EventArgs e)
        {
            UtilsComponent.setBorder(panelResultBack);
            caluLibre = new CalculadoraCaidaLibre();
            inputSelect.SetEventAction = (title) => {
                if (title.Trim().ToLower().Equals("Altura".ToLower().Trim()))
                {
                    numSelect = 0;
                    selectEnableIputs(false, true, true, true, true);
                }

                else if (title.Trim().ToLower().Equals("Tiempo".ToLower().Trim()))
                {
                    numSelect = 1;
                    selectEnableIputs(true, false, true, true, true);
                }
                else if (title.Trim().ToLower().Equals("Velocidad Final".ToLower().Trim()))
                {
                    numSelect = 2;
                    selectEnableIputs(true, true, false, true, true);
                }

                else if (title.Trim().ToLower().Equals("Velocidad Inicial".ToLower().Trim())) {
                    numSelect = 3;
                    selectEnableIputs(true, true, true, false, true);
                }
                else if (title.Trim().ToLower().Equals(" Velocidad Media".ToLower().Trim())) {
                    numSelect = 4;
                    selectEnableIputs(true, true, true, true, false);
                }else numSelect = -1;
            };

            btnCalcu.SetOnClick = () => {

                if (isValidNumberString(inpAltura) && isValidNumberString(inpTiempo) && isValidNumberString(inpVeFin)
                     && isValidNumberString(inpVeIni) && isValidNumberString(inpVeIMed) && isValidNumberString(inputGravedad))
                {
                    caluLibre.altura = parseString(inpAltura);
                    caluLibre.tiempo = parseString(inpTiempo);
                    caluLibre.velocidadFinal = parseString(inpVeFin);
                    caluLibre.velocidadInicial = parseString(inpVeIni);
                    caluLibre.velocidadMedia = parseString(inpVeIMed);

                    if (parseDouble(inputGravedad).ToString().Contains("-"))
                    {
                        caluLibre.gravedad = parDouble(parseDouble(inputGravedad).ToString().Replace("-", " "));
                    }
                    else
                    {
                        caluLibre.gravedad = parseDouble(inputGravedad);
                    }

                    if (inputGravedad.SetTextInput.Length > 0)
                    {
                        String[] res = caluLibre.getResultCalculation(numSelect);
                        txtResult.Text = "";
                        string unidad = "";
                        foreach (FormularioCaidaLibreModel item in caluLibre.formularioCaidaLibre)
                        {
                            unidad = item.unidad;
                            string result = item.identificador + " = " + item.valor + " " + item.unidad;
                            string form = "  Formula: " + String.Format(Environment.NewLine) + "    " + item.formula;
                            txtResult.Text += result + String.Format(Environment.NewLine);
                            txtResult.Text += form + String.Format(Environment.NewLine)
                                + "--------------------------------------------" + String.Format(Environment.NewLine);
                        }

                        for (int i = 0; i < res.Length; i++)
                        {
                            string num = res[0];
                            if (!res[0].Trim().Equals(caluLibre.message))
                            {
                                num = decimal.Round((decimal)parDouble(res[0]), 2).ToString();
                            }

                            string resultFinal = "Resultado: " + String.Format(Environment.NewLine) + num + " " + unidad;
                            txtResult.Text += resultFinal + String.Format(Environment.NewLine);
                        }

                    }
                }
                else {
                    txtResult.Text = "Ingrese solo números validos";
                }

                
            };
        }

        private void selectEnableIputs(bool al, bool t, bool vf, bool vo, bool vm) {
            inpAltura.Enabled = al;
            inpTiempo.Enabled = t;
            inpVeFin.Enabled = vf;
            inpVeIni.Enabled = vo;
            inpVeIMed.Enabled = vm;
            if (!al) inpAltura.SetTextInput = "";
            if (!t) inpTiempo.SetTextInput = "";
            if (!vf) inpVeFin.SetTextInput = "";
            if (!vo) inpVeIni.SetTextInput = "";
            if (!vm) inpVeIMed.SetTextInput = "";
            
            if (vo) inpVeIni.SetTextInput = "0";
            txtResult.Text = "";
        }

        private bool isEmptyInp(InputDefault def) {
            return !def.SetTextInput.Trim().Equals("");
        }
        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            inpAltura.SetTextInput = "";
            inpTiempo.SetTextInput = "";
            inpVeFin.SetTextInput = "";
            inpVeIni.SetTextInput = "";
            inpVeIMed.SetTextInput = "";
            inputGravedad.SetTextInput = "9.8";
            inpVeIni.SetTextInput = "0";
            txtResult.Text = "";
        }
    }
}
