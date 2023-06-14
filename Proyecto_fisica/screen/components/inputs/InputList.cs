using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ControlComponents.Component.Inputs
{
    internal class InputList : Panel
    {
        private Panel footer;
        private Panel header;
        private ComboBox tbName;
        private Action<String> eventHenOnclick;
        private Action<String,int> eventPosHenOnclick;

        public string titleLabel = "Nombre";
        public string txtInput = "";
        public float sizeTextLabel = 10F;
        public float sizeTextInput = 12F;
        public bool setEnableClick= true;
        public string[] dataList = {""};
        public Color colorText = Colors.colorBlack;
        public ContentAlignment alignmentLabel = ContentAlignment.BottomLeft;
        public int selectIndex = -1;
        public InputList()
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
                footer = UtilsComponent.setCreatePanel(new Size(0, (int)sizeTextInput * 2), Color.White, 1, DockStyle.Top);
                header = UtilsComponent.setCreatePanel(new Size(0, calIn), this.BackColor, 0, DockStyle.Top);

                footer.Paint += new PaintEventHandler(this.footer_Paint);
                header.Paint += new PaintEventHandler(this.header_Paint);

                Controls.AddRange(new Control[] { footer, header });

            }
        }


        // Footer PAINT
        private void footer_Paint(object sender, PaintEventArgs e)
        {
            if (footer.Controls.Count == 0)
            {
                int calIn = (int)sizeTextLabel * 2;
                tbName = new ComboBox();
                tbName.Dock = DockStyle.Fill;
                tbName.FlatStyle = FlatStyle.Flat;
                tbName.Font = new Font("Microsoft Sans Serif", sizeTextInput, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                tbName.Location = new Point(0, 0);
                tbName.Size = new Size(footer.Width, footer.Height);
                tbName.Text = txtInput;
                tbName.FormattingEnabled = false;
                tbName.Items.AddRange(dataList);
                tbName.KeyPress += (sen, es) =>{es.Handled = setEnableClick; };
                tbName.SelectedIndexChanged += new EventHandler(actionCombox_SelectedIndexChanged);
                tbName.SelectedIndex = selectIndex;

                footer.Controls.Add(tbName);
                footer.Size = new Size(0, Height - calIn);
                footer.Padding = new Padding(7);
                UtilsComponent.setBorder(footer);
            }
           
        }

        // Header PAINT
        private void header_Paint(object sender, PaintEventArgs e)
        {
            if (header.Controls.Count == 0)
            {
                Label tbName = UtilsComponent.setCreateLabel(titleLabel,
                    colorText, 10, DockStyle.Fill, alignmentLabel, sizeTextLabel, FontStyle.Bold);
                tbName.BackColor = BackColor;
                header.BackColor = BackColor;

                header.Controls.Add(tbName);
                header.Padding = new Padding(10, 0, 10, 0);
            }

        }

        private void actionCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (eventHenOnclick != null) eventHenOnclick(tbName.SelectedItem.ToString());
            if (eventPosHenOnclick != null) eventPosHenOnclick(tbName.SelectedItem.ToString(),tbName.SelectedIndex);

        }

        //Controladores get, set
        public string SetTextlabel
        {
            get { return titleLabel; }
            set
            {
                titleLabel = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public string[] SetItems
        {
            get { return dataList; }
            set
            {
                dataList = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        }

        public string SetTextInput
        {
            get { return tbName != null ? tbName.Text : ""; }
            set
            {
                txtInput = value;
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
        
        public int SeleccIndex
        {
            get { return selectIndex; }
            set
            {
                selectIndex = value;
                paintViewPanel(true);
                this.Invalidate();

            }
        } 
        
        public Action<String> SetEventAction
        {
            get { return eventHenOnclick; }
            set
            {
                eventHenOnclick = value;
                //paintViewPanel(true);
                this.Invalidate();

            }
        }

        public Action<String, int> SetEventActionPos
        {
            get { return eventPosHenOnclick; }
            set
            {
                eventPosHenOnclick = value;
                //paintViewPanel(true);
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
