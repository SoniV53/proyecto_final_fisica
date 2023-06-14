namespace Proyecto_fisica.screen
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.main = new System.Windows.Forms.Panel();
            this.body = new System.Windows.Forms.Panel();
            this.bodyLeft = new System.Windows.Forms.Panel();
            this.btnInfo = new ControlComponents.Component.ButtonIcon();
            this.btnSolucion = new ControlComponents.Component.ButtonIcon();
            this.btnUnidad = new ControlComponents.Component.ButtonIcon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.nav = new System.Windows.Forms.Panel();
            this.pnalNavbar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.iconHome = new System.Windows.Forms.PictureBox();
            this.main.SuspendLayout();
            this.bodyLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.nav.SuspendLayout();
            this.pnalNavbar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.main.BackColor = System.Drawing.Color.White;
            this.main.Controls.Add(this.body);
            this.main.Controls.Add(this.bodyLeft);
            this.main.Controls.Add(this.nav);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(984, 649);
            this.main.TabIndex = 0;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.WhiteSmoke;
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(215, 58);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(769, 591);
            this.body.TabIndex = 2;
            // 
            // bodyLeft
            // 
            this.bodyLeft.BackColor = System.Drawing.Color.SteelBlue;
            this.bodyLeft.Controls.Add(this.btnInfo);
            this.bodyLeft.Controls.Add(this.btnSolucion);
            this.bodyLeft.Controls.Add(this.btnUnidad);
            this.bodyLeft.Controls.Add(this.panel1);
            this.bodyLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.bodyLeft.Location = new System.Drawing.Point(0, 58);
            this.bodyLeft.Name = "bodyLeft";
            this.bodyLeft.Padding = new System.Windows.Forms.Padding(2, 0, 4, 0);
            this.bodyLeft.Size = new System.Drawing.Size(215, 591);
            this.bodyLeft.TabIndex = 1;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.btnInfo.Location = new System.Drawing.Point(5, 345);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(5);
            this.btnInfo.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnInfo.SetImageIcon = global::Proyecto_fisica.Properties.Resources.icon_perons_white;
            this.btnInfo.SetOnClick = null;
            this.btnInfo.SetPositionIcon = System.Windows.Forms.DockStyle.Left;
            this.btnInfo.SetSizeText = 10F;
            this.btnInfo.SetText = "Información del Estudiante";
            this.btnInfo.SetTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInfo.SetWidthIcon = 40;
            this.btnInfo.Size = new System.Drawing.Size(203, 63);
            this.btnInfo.TabIndex = 4;
            // 
            // btnSolucion
            // 
            this.btnSolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.btnSolucion.Location = new System.Drawing.Point(5, 260);
            this.btnSolucion.Name = "btnSolucion";
            this.btnSolucion.Padding = new System.Windows.Forms.Padding(5);
            this.btnSolucion.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSolucion.SetImageIcon = global::Proyecto_fisica.Properties.Resources.fisica_white;
            this.btnSolucion.SetOnClick = null;
            this.btnSolucion.SetPositionIcon = System.Windows.Forms.DockStyle.Left;
            this.btnSolucion.SetSizeText = 10F;
            this.btnSolucion.SetText = "Solución de Física";
            this.btnSolucion.SetTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSolucion.SetWidthIcon = 40;
            this.btnSolucion.Size = new System.Drawing.Size(203, 67);
            this.btnSolucion.TabIndex = 3;
            // 
            // btnUnidad
            // 
            this.btnUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.btnUnidad.Location = new System.Drawing.Point(5, 182);
            this.btnUnidad.Name = "btnUnidad";
            this.btnUnidad.Padding = new System.Windows.Forms.Padding(5);
            this.btnUnidad.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUnidad.SetImageIcon = global::Proyecto_fisica.Properties.Resources.unidad2_white;
            this.btnUnidad.SetOnClick = null;
            this.btnUnidad.SetPositionIcon = System.Windows.Forms.DockStyle.Left;
            this.btnUnidad.SetSizeText = 10F;
            this.btnUnidad.SetText = "Unidad de Medida";
            this.btnUnidad.SetTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUnidad.SetWidthIcon = 50;
            this.btnUnidad.Size = new System.Drawing.Size(203, 63);
            this.btnUnidad.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 174);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::Proyecto_fisica.Properties.Resources.fisica;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(209, 174);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // nav
            // 
            this.nav.BackColor = System.Drawing.Color.CornflowerBlue;
            this.nav.Controls.Add(this.pnalNavbar);
            this.nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.nav.Location = new System.Drawing.Point(0, 0);
            this.nav.Name = "nav";
            this.nav.Size = new System.Drawing.Size(984, 58);
            this.nav.TabIndex = 0;
            // 
            // pnalNavbar
            // 
            this.pnalNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.pnalNavbar.Controls.Add(this.panel2);
            this.pnalNavbar.Controls.Add(this.iconHome);
            this.pnalNavbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnalNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnalNavbar.Name = "pnalNavbar";
            this.pnalNavbar.Padding = new System.Windows.Forms.Padding(8);
            this.pnalNavbar.Size = new System.Drawing.Size(984, 58);
            this.pnalNavbar.TabIndex = 5;
            this.pnalNavbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavBarListView_MouseDown);
            this.pnalNavbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavBarListView_MouseMove);
            this.pnalNavbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavBarListView_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnMini);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(903, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 42);
            this.panel2.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Proyecto_fisica.Properties.Resources.close_white;
            this.btnClose.Location = new System.Drawing.Point(44, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 42);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMini.Image = global::Proyecto_fisica.Properties.Resources.mini;
            this.btnMini.Location = new System.Drawing.Point(0, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(24, 42);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 6;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // iconHome
            // 
            this.iconHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconHome.Image = global::Proyecto_fisica.Properties.Resources.fisica;
            this.iconHome.Location = new System.Drawing.Point(8, 8);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(63, 42);
            this.iconHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconHome.TabIndex = 4;
            this.iconHome.TabStop = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 649);
            this.Controls.Add(this.main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Física";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.main.ResumeLayout(false);
            this.bodyLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.nav.ResumeLayout(false);
            this.pnalNavbar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel nav;
        private System.Windows.Forms.Panel bodyLeft;
        private ControlComponents.Component.ButtonIcon btnInfo;
        private ControlComponents.Component.ButtonIcon btnSolucion;
        private ControlComponents.Component.ButtonIcon btnUnidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel pnalNavbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.PictureBox iconHome;
    }
}