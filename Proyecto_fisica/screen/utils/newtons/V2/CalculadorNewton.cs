using Proyecto_fisica.screen.utils.newtons.V2.calcNewton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_fisica.screen.utils.newtons.V2
{
    public class CalculadorNewton : BaseCalcNewton
    {

        private List<LeyesNewtonV2InputsModel> newtonX;
        private List<LeyesNewtonV2InputsModel> newtonY;
       
        private String MessageNot = "NO se pudo calcular";
        public ResultValuesNewtonModel resultValueY { get; set; }
        public ResultValuesNewtonModel resultValueX{ get; set; }
        public ResultValuesNewtonModel friccion{ get; set; }
        public ResultValuesNewtonModel coeficiente { get; set; }
        public ListaCalcultNewtonModel listDataValues { get; set; }

        private bool loadx = true;
        public CalculadorNewton(List<LeyesNewtonV2InputsModel> newtonX, 
                List<LeyesNewtonV2InputsModel> newtonY)
        {
           
            this.newtonX = newtonX;
            this.newtonY = newtonY;

            calcularNewtonY();
            if (loadx)
            {
                calcularNewtonX();
            }
            
           
            caltCoefi();
            listDataValues = new ListaCalcultNewtonModel(newtonX, newtonY);

        }

        private void caltCoefi() {
            string normal = calcSumNormal();

            if (friccion != null && !isEmpty(normal) && isValidNumberString(normal))
            {

                if (friccion.itemSelect != null)
                {
                    if (isEmpty(friccion.itemSelect.valueGradoU) && isEquals(friccion.itemSelect.name, "Fk") ||
                    isEquals(friccion.itemSelect.name, "Fs"))
                    {
                        double result = friccion.result / parDouble(normal);
                        coeficiente = new ResultValuesNewtonModel(result, friccion.itemSelect,
                            new string[] { normal, friccion.result.ToString() });

                    }
                }
                
            }
        }

        public void calcularNewtonY() {
            
            string status = printStatusReturData(newtonY);
            string json = JsonSerializer.Serialize(newtonY);
            //MessageBox.Show(json, "Data");

            if (isEquals(status, "03") )
            {
                resultValueY = calcSumFuerza(newtonY);
                //resultListY.Add(new ResultValuesNewtonModel(123, itemSelectY));
            }
            else if (isEquals(status, "0403"))
            {
                ResultValuesNewtonModel value = calcSumFuerza(newtonY);
                resultValueY = calcSumFuerzaSEN_CON( value);
               
            }
            else if (isContains(status, "01"))
            {
                calcularNewtonX();
                loadx = false;
                resultValueY = calcFriccion(newtonY, status);
                friccion = resultValueY;
               // resultValueY = getFriccion(newtonY); 
               
            }
 
        }

        public void calcularNewtonX()
        {

            string status = printStatusReturData(newtonX);
            string json = JsonSerializer.Serialize(newtonX);
            //MessageBox.Show(json, "Data");

            if (isEquals(status, "03"))
            {
                resultValueX = calcSumFuerza(newtonX);
                //resultListY.Add(new ResultValuesNewtonModel(123, itemSelectY));
            }
            else if (isEquals(status, "0403"))
            {
                ResultValuesNewtonModel value = calcSumFuerza(newtonX);
                resultValueX = calcSumFuerzaSEN_CON(value);

            }
            else if (isContains(status, "01"))
            {
                resultValueX = calcFriccion(newtonX, status);
                friccion = resultValueX;
                // resultValueY = getFriccion(newtonY); 

            }

           // statusValue = new ResultValuesNewtonModel("\nESTADO: " + status, null);

        }

        /*
         * Metodo que pita el estado de diferentes respuestas para poder evaluar un resultado
         */
        private string printStatusReturData(List<LeyesNewtonV2InputsModel> newt)
        {
            string status = "";
            int cont = 0;
            /* 
             *  01:0 = Si existe Friccion, 
             *  02:1 = si existe doble dato vacio,
             *  03:2 = si existe solo un dato vacio
             *  04:3 = si el valor de coseno o seno esta vacio
             *  05:3 = NO existe ningun valor vacio
            */
            foreach (var item in newt)
            {
                //01:0
                if (!status.Contains("01"))
                    status += isNumSelect(item, 2) ? "01" : "";

                //02:1
                if (!status.Contains("02"))
                    status += cont == 2 ? "02" : "";
                cont = isEmpty(item.value) ? cont += 1 : cont;

                cont = isNumSelect(item, 2) && cont > 0 && !isEmpty(item.value) && !isEmpty(item.valueGradoU) ? cont -= 1 : cont;

                //04:3
                if (!status.Contains("04"))
                    status +=  isNumSelect(item, 1) && isEmpty(item.value) ? "04" : "";

            }
            //03:2
            if (!status.Contains("03"))
                status += cont == 1 ? "03" : "";

            //05
           // status = cont == 0 ? "05" : status;

            return status;
        }

        //Metodos que calculan un valor segun el estado que corresponda
        private ResultValuesNewtonModel calcSumFuerza(List<LeyesNewtonV2InputsModel> newton)
        {
            LeyesNewtonV2InputsModel itemSelect = null;
            double result = 0;
            foreach (var item in newton)
            {
                if (!isEmpty(item.value))
                {
                    if (isNumSelect(item, 1))
                    {
                        result += addCalcSenCos(item);
                    }
                    else
                    {
                        if (!isNumSelect(item, 2))
                        {
                            result += parDouble(item.value);
                        }
                       
                    }
                }
                else
                {
                    if (!isNumSelect(item,2))
                    {
                        itemSelect = item;
                    }
                    
                }
            }

            return new ResultValuesNewtonModel(result, itemSelect);
        }

        private ResultValuesNewtonModel calcSumFuerzaSEN_CON(ResultValuesNewtonModel value)
        {
          
            LeyesNewtonV2InputsModel itemSelect = value.itemSelect;
            double result = value.result;

            if (itemSelect != null && !isEmpty(itemSelect.valueGradoU))
            {
                double num = parDouble(itemSelect.valueGradoU) * Math.PI / 180.0;
                result = isEquals(itemSelect.cosSen, "sen") ?
                    (result / Math.Sin(num)) :
                    (result / Math.Cos(num));
            }
            return new ResultValuesNewtonModel(result, itemSelect);
        }


        private ResultValuesNewtonModel calcFriccion(List<LeyesNewtonV2InputsModel> newton, string status)
        {
            ResultValuesNewtonModel resutFriccion = getFriccion(newton);
            ResultValuesNewtonModel calc = calcSumFuerza(newton);

            LeyesNewtonV2InputsModel itemSelect = resutFriccion.itemSelect;
            double result = 0;

           
            if (itemSelect != null)
            {
                result += calc.result;
            }
            else {
                if (isContains(status, "04"))
                {
                    calc.result += resutFriccion.result;

                    ResultValuesNewtonModel valueCo = calcSumFuerzaSEN_CON( calc);

                    result += valueCo.result;
                    itemSelect = valueCo.itemSelect;

                } else  {
                    calc.result += resutFriccion.result;

                    result += calc.result;
                    itemSelect = calc.itemSelect;
                } 
                
            }
            
            return new ResultValuesNewtonModel(result, itemSelect);
        }

        public string calcSumNormal()
        {
            string normarlX = isValidExisNormal(newtonX);
            string normarly = isValidExisNormal(newtonY);
            string result = isEquals(normarlX,"NOT") ? normarly : normarlX;

            if (isEmpty(result))
            {
                
                if (resultValueY != null && resultValueY.itemSelect != null && isNumSelect(resultValueY.itemSelect, 0))
                {
                    
                    result = resultValueY.result.ToString();
                }
              
                if (resultValueX != null && resultValueX.itemSelect != null && isNumSelect(resultValueX.itemSelect, 0))
                {
             
                    result = resultValueX.result.ToString();
                }

            }

            return result;
        }

        //Metodo que obtiene la friccion en un solo valor
        public ResultValuesNewtonModel getFriccion(List<LeyesNewtonV2InputsModel> newton)
        {
            LeyesNewtonV2InputsModel itemSelect = null;
            LeyesNewtonV2InputsModel friccionItem = getFriccionItem(newton);
            double result = 0;
            string normal = calcSumNormal();

            if (friccionItem != null)
            {
                if (!isEmpty(friccionItem.value))
                {
                    result = parDouble(friccionItem.value);
                }
                else if (!isEmpty(friccionItem.valueGradoU))
                {
                    if (isValidNumberString(normal))
                    {
                        result = parDouble(friccionItem.valueGradoU) * parDouble(normal);
                    }
                }
                else
                {
                    itemSelect = friccionItem;
                }

            }
            
          
            return new ResultValuesNewtonModel(result, itemSelect);
        }

        private LeyesNewtonV2InputsModel getFriccionItem(List<LeyesNewtonV2InputsModel> newton) {
            foreach (var item in newton)
            {
                if (isNumSelect(item, 2))
                {
                    return item;
                }
            }
            return null;
        }

        /**
         * Metodo que opera los valores que tenga seno o coseno
         */
        private double addCalcSenCos(LeyesNewtonV2InputsModel item)
        {
            double result = 0;

            if (!isEmpty(item.valueGradoU))
            {
                double num = parDouble(item.valueGradoU) * Math.PI / 180.0;
                result = isEquals(item.cosSen, "sen") ?
                    (Math.Sin(num) * parDouble(item.value)) :
                    (Math.Cos(num) * parDouble(item.value));

            }
            else
            {
                result = parDouble(item.value);
            }
            return result;
        }

        private string isValidExisNormal(List<LeyesNewtonV2InputsModel> newt)
        {
            string result = "NOT";
            foreach (var item in newt)
            {
                if (isEquals(item.name, "N"))
                {
                    result = item.value;
                }
            }
            return result;
        }
    }
}
