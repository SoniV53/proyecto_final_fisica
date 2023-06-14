using Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton;
using Proyecto_fisica.screen.utils.newtons;
using Proyecto_fisica.screen.utils.newtons.V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.VoiceCommands;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_fisica.screen.ui.solucionFisica
{
    public partial class LeyesNewtonV2Form : BaseForms
    {
        private GenerarInputsData generateX;
        private GenerarInputsData generateY;
        private List<ComboDataInputsModel> getExistDataCom;
        public LeyesNewtonV2Form()
        {
            InitializeComponent();
        }

        private void LeyesNewtonV2Form_Load(object sender, EventArgs e)
        {
            generateX = new GenerarInputsData(pnlItemsX);
            generateY = new GenerarInputsData(pnlItemsBodyY);
            getExistDataCom = new List<ComboDataInputsModel>();
            btnCalcu.SetOnClick = () => {
                generateY.updateItemsAddControl();
                generateX.updateItemsAddControl();

                if (generateX.listValue.Count > 0 && generateY.listValue.Count > 0)
                {
                    if (!isValidSoNumber(generateY.listValue) && !isValidSoNumber(generateX.listValue))
                    {
                        CalculadorNewton calculador = new CalculadorNewton(generateX.listValue, generateY.listValue);

                        ResultadoFinal resultadoFinal = new ResultadoFinal(
                            calculador.resultValueY, 
                            calculador.resultValueX, 
                            calculador.coeficiente,
                            calculador.listDataValues);
                        resultadoFinal.ShowDialog();
                    }
                    else {
                        MessageBox.Show("Ingrese solo números validos", "ERROR NUMERICO");
                    }
                   
                }
                else {
                    MessageBox.Show("No Existe ningun Datos O Faltan Datos", "ERROR");
                }

                //action();
            };
        }

        private bool isValidSoNumber(List<LeyesNewtonV2InputsModel> listValue) {
            foreach (var item in listValue)
            {
                if (item.type == 1 || item.type == 2)
                {
                    if (!isValidNumberString(item.value) && !isValidNumberString(item.valueGradoU))
                    {
                        return true;
                    }
                }
                else {
                    if (!isValidNumberString(item.value))
                    {
                        return true;
                    }
                }
               
            }

            return false;
        }

        private void action() {
            generateX.updateItemsAddControl();
            string text = "";
            generateX.listValue.ForEach(item => {
                text += item.name + " = " + item.value + " " + item.valueGradoU + String.Format(Environment.NewLine); ;

            });

            //label3.Text = text;
        }

        private void btnAddX_Click(object sender, EventArgs e)
        {
            
            AgregarInput agregarInput = new AgregarInput(false, generateX, generateY, getExistDataCom);
            agregarInput.ShowDialog();

            generateX.getItemsAddControl();

            if (agregarInput.addW)
            {
                generateY.getItemsAddControl();
            }
            
            
        }

        private void btnAddY_Click(object sender, EventArgs e)
        {
            AgregarInput agregarInput = new AgregarInput(true, generateY, generateX, getExistDataCom);
            agregarInput.ShowDialog();
            generateY.getItemsAddControl();
            if (agregarInput.addW)
            {
                generateX.getItemsAddControl();
            }
           
        }

        private void panelBodyX_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnDeleteX_Click(object sender, EventArgs e)
        {
            DeleteInputsSelect delete = new DeleteInputsSelect(generateX, getExistDataCom);
            delete.ShowDialog();
            generateX.getItemsAddControl();
        }

        private void btnDeleteY_Click(object sender, EventArgs e)
        {
            DeleteInputsSelect delete = new DeleteInputsSelect(generateY, getExistDataCom);
            delete.ShowDialog();
            generateY.getItemsAddControl();
        }
    }
}
