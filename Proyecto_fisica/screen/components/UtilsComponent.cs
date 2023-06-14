using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fisica.screen.components
{
    public class UtilsComponent
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public static void setBorder(Panel pn)
        {
            pn.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, pn.Width, pn.Height, 15, 15));
        }

        public static void setBorder(Label pn)
        {
            pn.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, pn.Width, pn.Height, 15, 15));
        }

        public static Panel setCreatePanel(Size size, Color bacColor, int index, DockStyle style = DockStyle.Fill)
        {
            Panel pnl = new Panel();
            pnl.Dock = style;
            pnl.Size = size;
            pnl.BackColor = bacColor;
            pnl.TabIndex = index;
            return pnl;
        }

        public static Label setCreateLabel(
            string title, Color color, int he, DockStyle st = DockStyle.Top,
            ContentAlignment ali = ContentAlignment.MiddleCenter, float sizeText = 10F, FontStyle fontStyle = FontStyle.Regular)
        {

            Label txtTitle = new Label();
            txtTitle.Dock = st;
            txtTitle.Size = new Size(0, he);
            txtTitle.AutoSize = false;
            txtTitle.Font = new Font("Microsoft Sans Serif", sizeText, fontStyle, GraphicsUnit.Point, ((byte)(0)));
            txtTitle.ForeColor = color;
            txtTitle.Text = title;
            txtTitle.TextAlign = ali;

            return txtTitle;
        }

        public static async void setMessage(Action sup, Action inf, int sleep = 2000)
        {
            if (sup != null) sup();

            Task task = new Task(() => {
                Thread.Sleep(sleep);
            });

            task.Start();
            await task;

            if (inf != null) inf();
        }

        public static void setFormPanelControlGeneral(
               bool requiere = true,
               object formHi = null,
               Panel panel = null,
               DockStyle style = DockStyle.Fill,
               bool size = false,
               Size si = new Size()
               )
        {

            if (formHi != null || panel != null)
            {

                if (requiere)
                {
                    if (panel.Controls.Count > 0)
                        panel.Controls.RemoveAt(0);
                }

                Form fh = formHi as Form;
                fh.TopLevel = false;
                fh.Dock = style;
                if (size) fh.Size = si;
                panel.Controls.Add(fh);
                panel.Tag = fh;
                fh.Show();
            }

            

        }
    }
}
