using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlComponents.Component.Cards
{
    internal class CardInformation : Panel
    {
        private Color referCo;

        public Action<string> onClick;
        public Action onClickPanel;
        public Color colorText = Color.FromArgb(240, 240, 240);   
        public Image imageHead;
        public Size sizeImageHead = new Size(0, 120);
        public string json = "";
        public Panel footer;
        public Panel main;
        public Panel imga;

        public Color colorButton = Colors.colorBluSucc;
        public Color colorTextButton = Color.FromArgb(240, 240, 240);
        public Color colorFontImage = Color.FromArgb(240, 240, 240);
        public string textButton = "Continuar";
        public float sizeTextButton = 12F;
        public int sizeButton = 65;
        public List<Label> labelMain = new List<Label>();

        //Controlador General
        public CardInformation()
        {
            this.Dock = DockStyle.None;
            this.Paint += new PaintEventHandler(this.main_Paint);
            referCo = BackColor;
        }
        // Body PAINT
        private void main_Paint(object sender, PaintEventArgs e)
        {

            paintViewPanel();
            if (referCo != BackColor)
            {
                paintViewPanel(true);
                referCo = BackColor;
            }

            this.Region = Region.FromHrgn(UtilsComponent.CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
            UtilsComponent.setBorder(imga);
            
        }

        public void paintViewPanel(bool clear = false)
        {
            if (clear) Controls.Clear();
            if (this.Controls.Count == 0)
            {
                imga = UtilsComponent.setCreatePanel(new Size(0, 0), colorFontImage, 2);
                imga.Padding = new Padding(10);  

                this.Region = Region.FromHrgn(UtilsComponent.CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
                int count = Height / 2;
                Panel header = UtilsComponent.setCreatePanel(sizeImageHead, this.BackColor, 0, DockStyle.Top);
                if (imageHead == null) header = UtilsComponent.setCreatePanel(new Size(0, 0), this.BackColor, 0, DockStyle.Top);
                footer = UtilsComponent.setCreatePanel(new Size(0, sizeButton), this.BackColor, 1, DockStyle.Bottom);
                main = UtilsComponent.setCreatePanel(new Size(0, 0), this.BackColor, 2);
                
                imga.Controls.Add(setCreatePictureBox(imageHead));
                
                header.Padding = new Padding(5);
                header.Controls.Add(imga);

                
                footer.Paint  += new PaintEventHandler(this.footer_Paint);
                main.Paint += new PaintEventHandler(this.body_Paint);
                main.AutoScroll = true;

                footer.Click += (es, s) => {
                    if (onClickPanel != null) onClickPanel();
                };

                main.Click += (es, s) => {
                    if (onClickPanel != null) onClickPanel();
                };

                header.Click += (es, s) => {
                    if (onClickPanel != null) onClickPanel();
                };

                this.Controls.AddRange(new Control[] { main, footer,header });
            }

            Click += (es, s) => {
                if (onClickPanel != null) onClickPanel();
            };
        }


        private PictureBox setCreatePictureBox(Image image)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Click += (es, s) => {
                if (onClickPanel != null) onClickPanel();
            };
            if (image != null) pictureBox.Image = image;
            return pictureBox;
        }

        // Footer PAINT

        private void footer_Paint(object sender, PaintEventArgs e)
        {
            if (footer.Controls.Count == 0)
            {
                ButtonIcon acep = getButtons(footer, textButton, DockStyle.Fill, colorButton, 1);

                acep.SetOnClick = () => { if (onClick != null) onClick(json); };

                footer.Controls.Add(acep);
                footer.Padding = new Padding(10);
            }
            
        }

        private ButtonIcon getButtons(Panel pa, string tex, DockStyle style, Color color, int ind)
        {
            ButtonIcon but = new ButtonIcon(pa.Width / 2 - 10, 0,sizeTextButton);
            but.SetColorText = colorTextButton;
            but.SetText = tex;
            but.BackColor = color;
            but.Dock = style;
            but.TabIndex = ind;
            return but;
        }

        // Main Paint
        private void body_Paint(object sender, PaintEventArgs e)
        {
            if (main.Controls.Count == 0)
            {
                if (labelMain.Count > 0) {
                    for (int i = 0; i < labelMain.Count; i++)
                    {
                        labelMain[i].Click += (es, s) => {
                            if (onClickPanel != null) onClickPanel();
                        };
                        main.Controls.Add(labelMain[i]);
                    }
                }
                
            }

        }

        //Controladores get, set
        public Image SetImageHead
        {
            get { return imageHead; }
            set
            {
                imageHead = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public Size SetSizeImageHead
        {
            get { return sizeImageHead; }
            set
            {
                sizeImageHead = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public Color SetColorButton
        {
            get { return colorButton; }
            set
            {
                colorButton = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }
        public Color SetColorBackImage
        {
            get { return colorFontImage; }
            set
            {
                colorFontImage = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public Color SetColorTextButton
        {
            get { return colorTextButton; }
            set
            {
                colorTextButton = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public string SetTextButton
        {
            get { return textButton; }
            set
            {
                textButton = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public float SetSizeTextButton
        {
            get { return sizeTextButton; }
            set
            {
                sizeTextButton = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public int SetSizeButton
        {
            get { return sizeButton; }
            set
            {
                sizeButton = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public Action<string> SetOnClick
        {
            get { return onClick; }
            set
            {
                onClick = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        } public Action SetOnClickPanel
        {
            get { return onClickPanel; }
            set
            {
                onClickPanel = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }
    }
}
