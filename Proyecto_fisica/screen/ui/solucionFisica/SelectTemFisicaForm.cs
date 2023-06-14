using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.menu;
using Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fisica.screen.ui.solucionFisica
{
    public partial class SelectTemFisicaForm : BaseForms
    {
        Panel bodyPanelMain;
        public SelectTemFisicaForm(Panel bodyPanelMain)
        {
            InitializeComponent();
            this.bodyPanelMain = bodyPanelMain;
        }

        private void SelectTemFisicaForm_Load(object sender, EventArgs e)
        {
            cardCaida.labelMain = new List<Label> { getNameCards("Caída libre") };
            cardNewton.labelMain = new List<Label> { getNameCards("1 y 3 Ley de Newton") };

            cardCaida.SetOnClickPanel = () => getPanelWelcome(0);
            cardNewton.SetOnClickPanel = () => getPanelWelcome();
        }

        private void getPanelWelcome(int view = -1)
        {

            switch (view)
            {
                case 0:
                    bodyPanelMain.Controls.Clear();
                    UtilsComponent.setFormPanelControlGeneral(false, new CaidaLibreForm(), bodyPanelMain);
                    break;
                default:
                    InstruccionesNewton instruccionesNewton = new InstruccionesNewton(bodyPanelMain);
                    instruccionesNewton.ShowDialog();
                    
                    //UtilsComponent.setFormPanelControlGeneral(false, new LeyesNewtonV2Form(), bodyPanelMain);
                    break;
            }

        }
    }
}
