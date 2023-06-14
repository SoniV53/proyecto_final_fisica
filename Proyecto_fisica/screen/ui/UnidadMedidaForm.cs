using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.utils;
using Proyecto_fisica.screen.utils.medida;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proyecto_fisica.screen.ui
{
    public partial class UnidadMedidaForm : Form
    {
        Panel bodyPanelMain;
        private ListUnidadMedidas listUnidadMedidas;
        private ConvertidorMedida conv;
        private String[] listMedida;
        private string typeUnid = "Masa";
        public UnidadMedidaForm(Panel bodyPanelMain)
        {
            InitializeComponent();
            this.bodyPanelMain = bodyPanelMain;
            txtMessage.Visible = false;

        }

        private void UnidadMedidaForm_Load(object sender, EventArgs e)
        {
            listUnidadMedidas = new ListUnidadMedidas();
            conv = new ConvertidorMedida();
            UtilsComponent.setBorder(panelResult);
            txtMessage.Region = Region.FromHrgn(UtilsComponent.CreateRoundRectRgn(2, 3, txtMessage.Width, txtMessage.Height, 15, 15));
            rbMasa.Checked = true;
            inputSelect1.SetEventAction = (title) => {
                getArrayItemsList(false, title);
                txtResult.Text = "";
            };

            btnConver.SetOnClick = () =>
            {
                if (inputNum.SetTextInput.Length > 0 && inputSelect1.SetTextInput.Length > 0 && inputSelect2.SetTextInput.Length > 0) {
                    Regex regex = new Regex("^[0-9]+([.][0-9]+)?$");
                    Regex regexNe = new Regex("^([-][0-9]+)+([.][0-9]+)?$");
                    if (regex.IsMatch(inputNum.SetTextInput.Trim()) || 
                        regexNe.IsMatch(inputNum.SetTextInput.Trim()))
                    {
           
                        txtResult.Text =
                        conv.selectTypeUnidad(typeUnid,
                            double.Parse(inputNum.SetTextInput.Trim()),
                            inputSelect1.SetTextInput,
                            inputSelect2.SetTextInput);
                        inputNum.SetTextInput = inputNum.SetTextInput.ToString().Trim();
                    }
                    else {
                       
                        UtilsComponent.setMessage(
                            () => { txtMessage.Visible = true; }, 
                            () => { txtMessage.Visible = false; });
                        inputNum.SetTextInput = "1";
                        txtResult.Text = "";
                    }  
                    
                }
                    
            };
        }

       
        /**
         * METODOD SE SELECCION DE TIPO DE UNIDAD DE MEDIDA
         */
        private void selectMedida() {

            if (rbMasa.Checked)
                typeUnid = "Masa";
            else if (rbTiempo.Checked)
                typeUnid = "Tiempo";
            else 
                typeUnid = "Longitud";

            listMedida = listUnidadMedidas.getComboText(listUnidadMedidas.unidaLists(), typeUnid);
            txtResult.Text = "";
            getArrayItemsList();
        }
        /**
        * METODOD QUE LLENA LOS COMBO BOX SEGUN EL TIPO DE UNIDAD DE MEDIDA
        */
        private void getArrayItemsList(bool selec = true,String txtSele = "") {
            if (listMedida != null)
            {
                if (selec) inputSelect1.SetItems = listMedida;
                if (!txtSele.Trim().Equals("")) inputSelect2.SetItems = listUnidadMedidas.medidaRepetida(listMedida, txtSele);
                else inputSelect2.SetItems = new string[0];
            }
            
        }

        private void rbTiempo_CheckedChanged(object sender, EventArgs e)
        {
            selectMedida();
        }

        private void rbLongitud_CheckedChanged(object sender, EventArgs e)
        {
            selectMedida();
        }

        private void rbMasa_CheckedChanged(object sender, EventArgs e)
        {
            selectMedida();
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = true;
        }

     
    }
}
