using Proyecto_fisica.screen.utils.newtons.V2;
using Proyecto_fisica.screen.utils.newtons.V2.calcNewton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Foundation;

namespace Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton
{
    public partial class ResultadoFinal : BaseForms
    {
        private ResultValuesNewtonModel resultValueY;
        private ResultValuesNewtonModel resultValueX;
        private ResultValuesNewtonModel coeficiente;
        private ListaCalcultNewtonModel listNewton;

        public ResultadoFinal(ResultValuesNewtonModel resultValueY,
            ResultValuesNewtonModel resultValueX,
            ResultValuesNewtonModel coeficiente,
            ListaCalcultNewtonModel listNewton)
        {
            InitializeComponent();
            this.resultValueY = resultValueY;
            this.resultValueX = resultValueX;
            this.coeficiente = coeficiente;
            this.listNewton = listNewton;
        }
        private void ResultadoFinal_Load(object sender, EventArgs e)
        {


            //status = statusValue.status != null ? statusValue.status : "";

            txtResultY.Text = resultValueY != null ? printNewton(listNewton.newtonY, "y") + formatResult(resultValueY) : "No se pudo calcular";
            txtResultX.Text = resultValueX != null ? printNewton(listNewton.newtonX, "x") + formatResult(resultValueX) : "No se pudo calcular";

            string resultVa = "";
            if (coeficiente != null && coeficiente.itemSelect != null && isEmpty(coeficiente.itemSelect.valueGradoU))
            {
                resultVa = formatResult(coeficiente, true);
                string coe = formtCoefi(coeficiente, true);
                string form = coe + " = " + coeficiente.itemSelect.name + " / N " + saltoLinea();
                form += coe + " = " + roundDouble(parDecimal(coeficiente.extraValues[1])) + " / " + roundDouble(parDecimal(coeficiente.extraValues[0])) + saltoLinea();
                form += resultVa;
                txtExtras.Text = form;
            }


            //decimal.Round((decimal)parDouble(res[0]), 2).ToString();
        }

        private string printNewton(List<LeyesNewtonV2InputsModel> newton, string type) {
            string resultFin = "";

            resultFin = "∑F(" + type + ") = 0" + saltoLinea();
            int cont = 0;
            foreach (var item in newton)
            {
                string sig = sigNum(item);
                sig = cont == 0 && isEquals(sig, "+") ? "" : sig;

                resultFin += sig + item.name;
                cont++;
            }
            resultFin += " = 0" + saltoLinea();

            return resultFin;
        }

        private string sigNum(LeyesNewtonV2InputsModel item)
        {
            return item.value.Contains("-") ? "-" : "+";    
        }   

        private string formatResult(ResultValuesNewtonModel item, bool isValid = false) {
            if (item.itemSelect != null )
            {
                return formtCoefi(item,isValid) + " = " + decimal.Round((decimal)item.result, 2).ToString();
            }else {
                return  item.result.ToString();
            }
        }

        private string roundDouble(decimal it) {
            return decimal.Round(it, 2).ToString();
        }

        private string formtCoefi(ResultValuesNewtonModel item, bool isValid = false) {
            string resulItem = item.itemSelect != null ? item.itemSelect.name : "";
            if (item.itemSelect != null && item.itemSelect.type == 2 && isValid)
            {
                resulItem = isEquals(resulItem, "Fk") ? "Uk" : "Us";
            }
            return resulItem;
        }
    }
}
