using Proyecto_fisica.screen.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Proyecto_fisica.screen.components.inputs
{
    public class InputAddSuma : Panel
    {
        private Panel footerLeft;
        private Panel headerLeft;
        private Panel panelLeft;
        private TextBox tbNameLeft;
        public string txtInputLeft = "";

        private TextBox tbNameRight;
        private Panel footerRight;
        private Panel headerRight;
        private Panel panelRight;
        public string txtInputRight = "";

        public string titleLabel = "T1";
        public string titleLabelGrado = "0";
        public int position = 0;
        public float sizeTextLabel = 10F;
        public float sizeTextInput = 12F;
        public bool setEnable = true;
        private int sizeDef = 0;

        public Color colorText = Colors.colorBlack;
        public ContentAlignment alignmentLabel = ContentAlignment.BottomLeft;

        
        public InputAddSuma()
        {
            this.Dock = DockStyle.None;
            this.Paint += new PaintEventHandler(this.main_Paint);
            sizeDef = Width;
        }

        //Body Paint
        private void main_Paint(object sender, PaintEventArgs e)
        {
            if (sizeDef != Width)
            {
                paintViewPanel(true);
                sizeDef = Width;
            }else paintViewPanel();

            UtilsComponent.setBorder(this);
        }

        public void paintViewPanel(bool clear = false)
        {
            if (clear) Controls.Clear();
            if (this.Controls.Count == 0)
            {
                int wi = Width / 3;
                int wiR = Width - (wi + 10);

                panelRight = UtilsComponent.setCreatePanel(new Size(wi, 0), this.BackColor, 1, DockStyle.Right);
                panelLeft = UtilsComponent.setCreatePanel(new Size(wiR, 0), this.BackColor, 1, DockStyle.Left);

                Paint += new PaintEventHandler(this.bodyPanel_Paint);
                Controls.AddRange(new Control[] { panelRight, panelLeft });

            }
        }

        // Panel PAINT Left
        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {
            if (panelLeft.Controls.Count == 0)
            {
                int calIn = (int)sizeTextLabel * 2;
                footerLeft = UtilsComponent.setCreatePanel(new Size(0, Height - calIn), Color.White, 1, DockStyle.Top);
                headerLeft = UtilsComponent.setCreatePanel(new Size(0, calIn), this.BackColor, 0, DockStyle.Top);

                footerLeft.Paint += new PaintEventHandler(this.footer_Paint);
                headerLeft.Paint += new PaintEventHandler(this.header_Paint);


                panelLeft.Controls.AddRange(new Control[] { footerLeft, headerLeft });
               
            }
            if (panelRight.Controls.Count == 0)
            {
                int calIn = (int)sizeTextLabel * 2;
                footerRight = UtilsComponent.setCreatePanel(new Size(0, Height - calIn), Color.White, 1, DockStyle.Top);
                headerRight = UtilsComponent.setCreatePanel(new Size(0, calIn), this.BackColor, 0, DockStyle.Top);

                footerRight.Paint += new PaintEventHandler(this.footer_Paint);
                headerRight.Paint += new PaintEventHandler(this.footer_Paint);


                panelRight.Controls.AddRange(new Control[] { footerRight, headerRight });

            }

        }

        // Footer PAINT
        private void footer_Paint(object sender, PaintEventArgs e)
        {
            if (footerLeft.Controls.Count == 0)
            {
                int calIn = (int)sizeTextLabel * 2;
                tbNameLeft = new TextBox();
                tbNameLeft.Dock = DockStyle.Fill;
                tbNameLeft.Multiline = true;
                tbNameLeft.BorderStyle = BorderStyle.None;
                tbNameLeft.Font = new Font("Microsoft Sans Serif", sizeTextInput, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                tbNameLeft.Location = new Point(0, 0);
                tbNameLeft.Enabled = setEnable;
                tbNameLeft.Text = txtInputLeft;

                footerLeft.Controls.AddRange(new Control[] { tbNameLeft });
                footerLeft.Size = new Size(0, Height - calIn);
                footerLeft.Padding = new Padding(5);
            }

            if (footerRight.Controls.Count == 0)
            {
                int calIn = (int)sizeTextLabel * 2;
                tbNameRight = new TextBox();
                tbNameRight.Dock = DockStyle.Fill;
                tbNameRight.Multiline = true;
                tbNameRight.BorderStyle = BorderStyle.None;
                tbNameRight.Font = new Font("Microsoft Sans Serif", sizeTextInput, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                tbNameRight.Location = new Point(0, 0);
                tbNameRight.Enabled = setEnable;
                tbNameRight.Text = txtInputRight;

                footerRight.Controls.AddRange(new Control[] { tbNameRight });
                footerRight.Size = new Size(0, Height - calIn);
                footerRight.Padding = new Padding(5);
            }

            
        }

      
        // Header PAINT 
        private void header_Paint(object sender, PaintEventArgs e)
        {
            if (headerLeft.Controls.Count == 0)
            {
                Label tbName = UtilsComponent.setCreateLabel(titleLabel,
                    colorText, 10, DockStyle.Fill, alignmentLabel, sizeTextLabel, FontStyle.Bold);
                tbName.BackColor = BackColor;
                headerLeft.BackColor = BackColor;

                headerLeft.Controls.Add(tbName);
                headerLeft.Padding = new Padding(10, 0, 10, 0);
            }
            if (headerRight.Controls.Count == 0)
            {
                //"θ"
                Label tbName = UtilsComponent.setCreateLabel(titleLabelGrado,
                    colorText, 10, DockStyle.Fill, alignmentLabel, sizeTextLabel, FontStyle.Bold);
                tbName.BackColor = BackColor;
                headerRight.BackColor = BackColor;

                headerRight.Controls.Add(tbName);
                headerRight.Padding = new Padding(10, 0, 10, 0);
            }
        }


        //Controladores get, set
        public string SetTextlabel
        {
            get { return titleLabel; }
            set
            {
                this.Invalidate();

                titleLabel = value;
                paintViewPanel(true);

            }
        } 
        
        public string SetTextlabelGrado
        {
            get { return titleLabelGrado; }
            set
            {
                this.Invalidate();

                titleLabelGrado = value;
                paintViewPanel(true);

            }
        }

        public string SetTextInputLeft
        {
            get { return tbNameLeft != null ? tbNameLeft.Text : ""; }
            set
            {
                txtInputLeft = value;
                paintViewPanel(true);
                this.Invalidate();
            }
        } 
        
        public string SetTextInputRight
        {
            get { return tbNameRight != null ? tbNameRight.Text : ""; }
            set
            {
                txtInputRight = value;
                paintViewPanel(true);
                this.Invalidate();
            }
        }
        public bool SetEnable
        {
            get { return setEnable; }
            set
            {
                setEnable = value;
                paintViewPanel(true);
                this.Invalidate();
            }
        }
        public float SetSizeLabel
        {
            get { return sizeTextLabel; }
            set
            {
                sizeTextLabel = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public float SetSizeInput
        {
            get { return sizeTextInput; }
            set
            {
                sizeTextInput = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public ContentAlignment SetAlignmentLabel
        {
            get { return alignmentLabel; }
            set
            {
                alignmentLabel = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public Color SetColorText
        {
            get { return colorText; }
            set
            {
                colorText = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }
    }
}
