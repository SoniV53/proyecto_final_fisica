using Proyecto_fisica.screen.components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlComponents.Component
{
    public class ButtonIcon : Panel
    {
        public Label txtTitle;
        public Action onClick;

        public Color colorText = Color.FromArgb(240, 240, 240);
        public string textTitle = "Ver Item";
        public float sizeTextButton = 10F;
        public ContentAlignment textAlignment = ContentAlignment.MiddleCenter;

        public Image imageIcon;
        public DockStyle styleIcon = DockStyle.Right;
        public int widthIcon = 30;

        public ButtonIcon(int wi, int h, float sizeTextButton = 10)
        {
            this.Dock = DockStyle.None;
            this.Paint += new PaintEventHandler(this.main_Paint);
            Size = new Size(wi, h);
            this.sizeTextButton = sizeTextButton;
        }

        public ButtonIcon()
        {
            this.Dock = DockStyle.None;
            this.Paint += new PaintEventHandler(this.main_Paint);
        }
        private void main_Paint(object sender, PaintEventArgs e)
        {
            paintViewPanel();
            this.Region = Region.FromHrgn(UtilsComponent.CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
        }

        private void paintViewPanel(bool clear = false)
        {
            if(clear)Controls.Clear();  
            if (this.Controls.Count == 0)
            {
                txtTitle = new Label();
                txtTitle.Dock = DockStyle.Fill;
                txtTitle.AutoSize = false;
                txtTitle.Font = new Font("Microsoft Sans Serif", sizeTextButton, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtTitle.ForeColor = colorText; 
                txtTitle.Text = textTitle;
                txtTitle.TextAlign = textAlignment;
                txtTitle.Click += new EventHandler(this.onClickAction_Click);

                Panel pnlIcon = UtilsComponent.setCreatePanel(new Size(widthIcon, 0), BackColor, 1, styleIcon);
                pnlIcon.Click += new EventHandler(this.onClickAction_Click);
                pnlIcon.Controls.Add(setCreatePictureBox(imageIcon, new EventHandler(this.onClickAction_Click)));
                if (imageIcon == null) pnlIcon.Size = new Size(0, 0);

                if (styleIcon == DockStyle.Left) pnlIcon.Padding = new Padding(0, 0, 5, 0);
                else pnlIcon.Padding = new Padding(5, 0, 0, 0);

                this.Padding = new Padding(5);
                Controls.AddRange(new Control[] { txtTitle, pnlIcon });
            }
        }

        private PictureBox setCreatePictureBox(Image image, EventHandler eventHan)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Click += eventHan;
            if (image != null) pictureBox.Image = image;
            return pictureBox;
        }


        private void onClickAction_Click(object sender, EventArgs e)
        {
            if(onClick != null) onClick();
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

        public ContentAlignment SetTextAlignment
        {
            get { return textAlignment; }
            set
            {
                textAlignment = value;
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

        public string SetText
        {
            get { return textTitle; }
            set
            {
                textTitle = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public float SetSizeText
        {
            get { return sizeTextButton; }
            set
            {
                sizeTextButton = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public Action SetOnClick
        {
            get { return onClick; }
            set
            {
                onClick = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

    }
}
