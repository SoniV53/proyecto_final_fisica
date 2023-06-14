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

namespace Proyecto_fisica.screen.ui
{
    public partial class InformacionPersonalForm : Form
    {
        Panel bodyPanelMain;
        public InformacionPersonalForm(Panel bodyPanelMain)
        {
            InitializeComponent();
            this.bodyPanelMain = bodyPanelMain;
        }

        private void InformacionPersonalForm_Load(object sender, EventArgs e)
        {
            UtilsComponent.setBorder(panel1);
            UtilsComponent.setBorder(panel5);
            UtilsComponent.setBorder(panel6);
            UtilsComponent.setBorder(panel7);
           
           
        }
    }
}
