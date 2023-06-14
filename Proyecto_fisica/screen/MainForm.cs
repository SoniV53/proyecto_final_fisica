using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.menu;
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

namespace Proyecto_fisica.screen
{
    public partial class MainForm : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;
  
        public MainForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(UtilsComponent.CreateRoundRectRgn(2, 3, Width, Height, 15, 15));
            getPanelWelcome();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            btnUnidad.SetOnClick = () => getPanelWelcome(0); 
            btnInfo.SetOnClick = () => getPanelWelcome(1); 
            btnSolucion.SetOnClick = () => getPanelWelcome(2); 

        }

        private void getPanelWelcome(int view  = -1){

            body.Controls.Clear();

            switch (view)
            {
                case 0:
                    UtilsComponent.setFormPanelControlGeneral(false, new UnidadMedidaForm(body), body);
                    break;
                case 1:
                    UtilsComponent.setFormPanelControlGeneral(false, new InformacionPersonalForm(body), body);
                    break;
                case 2:
                    UtilsComponent.setFormPanelControlGeneral(false, new SelectTemFisicaForm(body), body);
                    break;
                default:
                    UtilsComponent.setFormPanelControlGeneral(false, new MenuWelcomeForm(body), body);
                    break;
            }

           
        }

        private void NavBarListView_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void NavBarListView_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void NavBarListView_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            getPanelWelcome();

        }

        private void iconHome_Click(object sender, EventArgs e)
        {
            getPanelWelcome();
        }
    }
}
