using Proyecto_fisica.screen.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton
{
    public partial class InstruccionesNewton : Form
    {
        Panel bodyPanelMain;
        public InstruccionesNewton(Panel bodyPanelMain)
        {
            InitializeComponent();
            this.bodyPanelMain = bodyPanelMain;
        }

        private void InstruccionesNewton_Load(object sender, EventArgs e)
        {
            aceptar.SetOnClick = () => {
                bodyPanelMain.Controls.Clear();
                UtilsComponent.setFormPanelControlGeneral(false, new LeyesNewtonV2Form(), bodyPanelMain);
                Close();
            };
        }
    }
}
