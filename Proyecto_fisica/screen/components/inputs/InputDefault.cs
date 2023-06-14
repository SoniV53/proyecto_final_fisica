using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ControlComponents.Component.Inputs
{
    public class InputDefault : Panel
    {

        private Panel footer;
        private Panel header;
        private TextBox tbName;

        public string titleLabel = "Nombre";
        public string txtInput = "";
        public float sizeTextLabel = 10F;
        public float sizeTextInput = 12F;
        public bool setEnable = true;
        public bool setEnableClick = false;

        public Image imageIcon;
        public DockStyle styleIcon = DockStyle.Right;
        public int widthIcon = 20;

        public Color colorText = Colors.colorBlack;
        public ContentAlignment alignmentLabel = ContentAlignment.BottomLeft;

        public Action<string> onClick = null;
        public InputDefault()
        {
            this.Dock = DockStyle.None;
            this.Paint += new PaintEventHandler(this.main_Paint);
        }

        //Body Paint
        private void main_Paint(object sender, PaintEventArgs e)
        {
            paintViewPanel();
            UtilsComponent.setBorder(this);
        }

        private void paintViewPanel(bool clear = false)
        {
            if (clear) Controls.Clear();
            if (this.Controls.Count == 0)
            {
                int calIn = (int)sizeTextLabel * 2;
                footer = UtilsComponent.setCreatePanel(new Size(0, Height - calIn), Color.White, 1, DockStyle.Top);
                header = UtilsComponent.setCreatePanel(new Size(0, calIn), this.BackColor, 0, DockStyle.Top);

                footer.Paint += new PaintEventHandler(this.footer_Paint);
                header.Paint += new PaintEventHandler(this.header_Paint);

                Controls.AddRange(new Control[] { footer, header});
               
            }
        }

      
        // Footer PAINT
        private void footer_Paint(object sender, PaintEventArgs e)
        {
            if (footer.Controls.Count == 0)
            {
                int calIn = (int)sizeTextLabel * 2;
                tbName = new TextBox();
                tbName.Dock = DockStyle.Fill;
                tbName.Multiline = true;
                tbName.BorderStyle = BorderStyle.None;
                tbName.Font = new Font("Microsoft Sans Serif", sizeTextInput, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                tbName.Location = new Point(0, 0);
                tbName.Enabled = setEnable;
                tbName.Text = txtInput;
                tbName.KeyPress += (sen, es) => { es.Handled = setEnableClick; };
                tbName.Size = new Size(0,0);

                Panel pnlIcon = UtilsComponent.setCreatePanel(new Size(widthIcon, 0), Color.White, 1, styleIcon);
                pnlIcon.Controls.Add(setCreatePictureBox(imageIcon));
                if (imageIcon == null)pnlIcon.Size = new Size(0, 0);

                if (styleIcon == DockStyle.Left) pnlIcon.Padding = new Padding(0,0,5,0);
                else pnlIcon.Padding = new Padding(5, 0,0, 0);


                footer.Controls.AddRange(new Control[] {tbName, pnlIcon });
                footer.Size = new Size(0, Height - calIn);
                footer.Padding = new Padding(10);
            }
            UtilsComponent.setBorder(footer);
        }

        private PictureBox setCreatePictureBox(Image image)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Click += PictureBox_Click;
            if (image != null) pictureBox.Image = image;
            return pictureBox;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
           if(onClick != null) onClick(tbName != null ? tbName.Text : "");
        }

        // Header PAINT
        private void header_Paint(object sender, PaintEventArgs e)
        {
            if (header.Controls.Count == 0)
            {
                Label tbName = UtilsComponent.setCreateLabel(titleLabel, 
                    colorText,10,DockStyle.Fill, alignmentLabel, sizeTextLabel,FontStyle.Bold);
                tbName.BackColor = BackColor;
                header.BackColor = BackColor;
                if (titleLabel.Length == 0) {
                    header.Size = new Size();
                    footer.Dock = DockStyle.Fill;
                }
               
                header.Controls.Add(tbName);
                header.Padding = new Padding(10,0,10,0);
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

        public string SetTextInput
        {
            get { return tbName != null? tbName.Text: ""; }
            set
            {
                txtInput = value;
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

        public bool SetEnableClick
        {
            get { return setEnableClick; }
            set
            {
                setEnableClick = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public Image SetImageIcon
        {
            get { return imageIcon; }
            set
            {
                imageIcon = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public int SetWidthIcon
        {
            get { return widthIcon; }
            set
            {
                widthIcon = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public DockStyle SetPositionIcon
        {
            get { return styleIcon; }
            set
            {
                styleIcon = value;
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
