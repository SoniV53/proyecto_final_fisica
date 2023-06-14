using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.ui;
using Proyecto_fisica.screen.ui.solucionFisica;
using Proyecto_fisica.screen.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fisica.screen.menu
{
    public partial class MenuWelcomeForm : BaseForms
    {
        Panel bodyPanelMain;
        public MenuWelcomeForm(Panel bodyPanelMain)
        {
            InitializeComponent();
            this.bodyPanelMain = bodyPanelMain;
        }

        private void MenuWelcomeForm_Load(object sender, EventArgs e)
        {
            cardUnid.labelMain = new List<Label> { getNameCards("Unidad de Medida") };
            cardSolucion.labelMain = new List<Label> { getNameCards("Solución de Física") };
            cardInfo.labelMain = new List<Label> { getNameCards("Información del Estudiante") };

            cardUnid.SetOnClickPanel = () => getPanelWelcome(0);
            cardInfo.SetOnClickPanel = () => getPanelWelcome(1);
            cardSolucion.SetOnClickPanel = () => getPanelWelcome(2);

        }



        private void getPanelWelcome(int view = -1)
        {

            bodyPanelMain.Controls.Clear();

            switch (view)
            {
                case 0:
                    UtilsComponent.setFormPanelControlGeneral(false, new UnidadMedidaForm(bodyPanelMain), bodyPanelMain);
                    break;
                case 1:
                    UtilsComponent.setFormPanelControlGeneral(false, new InformacionPersonalForm(bodyPanelMain), bodyPanelMain);
                    break;               
                case 2:
                    UtilsComponent.setFormPanelControlGeneral(false, new SelectTemFisicaForm(bodyPanelMain), bodyPanelMain);
                    break;
                default:
                    UtilsComponent.setFormPanelControlGeneral(false, new MenuWelcomeForm(bodyPanelMain), bodyPanelMain);
                    break;
            }

        }

        private void cardUnid_MouseClick(object sender, MouseEventArgs e)
        {
            getPanelWelcome(0);
        }

        private void cardSolucion_MouseClick(object sender, MouseEventArgs e)
        {
            getPanelWelcome(2);
        }

        private void cardInfo_MouseClick(object sender, MouseEventArgs e)
        {
            getPanelWelcome(1);
        }

        private void cardUnid_Click(object sender, EventArgs e)
        {
            getPanelWelcome(0);
        }
    }
}
