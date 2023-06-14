namespace Proyecto_fisica.screen.ui.solucionFisica
{
    partial class CaidaLibreForm
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
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelResultBack = new System.Windows.Forms.Panel();
            this.inputSelect = new ControlComponents.Component.Inputs.InputList();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.inputGravedad = new ControlComponents.Component.Inputs.InputDefault();
            this.inpAltura = new ControlComponents.Component.Inputs.InputDefault();
            this.btnCalcu = new ControlComponents.Component.ButtonIcon();
            this.inpTiempo = new ControlComponents.Component.Inputs.InputDefault();
            this.inpVeFin = new ControlComponents.Component.Inputs.InputDefault();
            this.inpVeIMed = new ControlComponents.Component.Inputs.InputDefault();
            this.inpVeIni = new ControlComponents.Component.Inputs.InputDefault();
            this.header.SuspendLayout();
            this.body.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelResultBack.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(769, 104);
            this.header.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 104);
            this.label1.TabIndex = 6;
            this.label1.Text = "Caída libre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // body
            // 
            this.body.Controls.Add(this.panelResult);
            this.body.Controls.Add(this.panel2);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 104);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(769, 487);
            this.body.TabIndex = 2;
            // 
            // panelResult
            // 
            this.panelResult.AutoScroll = true;
            this.panelResult.BackColor = System.Drawing.Color.Transparent;
            this.panelResult.Controls.Add(this.panelResultBack);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(247, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Padding = new System.Windows.Forms.Padding(20);
            this.panelResult.Size = new System.Drawing.Size(522, 487);
            this.panelResult.TabIndex = 7;
            // 
            // panelResultBack
            // 
            this.panelResultBack.AutoScroll = true;
            this.panelResultBack.BackColor = System.Drawing.Color.Gainsboro;
            this.panelResultBack.Controls.Add(this.inputSelect);
            this.panelResultBack.Controls.Add(this.txtResult);
            this.panelResultBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultBack.Location = new System.Drawing.Point(20, 20);
            this.panelResultBack.Name = "panelResultBack";
            this.panelResultBack.Padding = new System.Windows.Forms.Padding(10);
            this.panelResultBack.Size = new System.Drawing.Size(482, 447);
            this.panelResultBack.TabIndex = 0;
            // 
            // inputSelect
            // 
            this.inputSelect.Location = new System.Drawing.Point(13, 13);
            this.inputSelect.Name = "inputSelect";
            this.inputSelect.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inputSelect.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputSelect.SetEnableClick = true;
            this.inputSelect.SetEventAction = null;
            this.inputSelect.SetItems = new string[] {
        "Altura",
        "Tiempo",
        "Velocidad Final",
        "Velocidad Inicial",
        "Velocidad Media"};
            this.inputSelect.SetSizeInput = 12F;
            this.inputSelect.SetSizeLabel = 10F;
            this.inputSelect.SetTextInput = "";
            this.inputSelect.SetTextlabel = "Seleccione que va a calcular";
            this.inputSelect.Size = new System.Drawing.Size(251, 61);
            this.inputSelect.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(10, 99);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(462, 338);
            this.txtResult.TabIndex = 1;
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.inputGravedad);
            this.panel2.Controls.Add(this.inpAltura);
            this.panel2.Controls.Add(this.btnCalcu);
            this.panel2.Controls.Add(this.inpTiempo);
            this.panel2.Controls.Add(this.inpVeFin);
            this.panel2.Controls.Add(this.inpVeIMed);
            this.panel2.Controls.Add(this.inpVeIni);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 487);
            this.panel2.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Proyecto_fisica.Properties.Resources.Limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(213, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(34, 33);
            this.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // inputGravedad
            // 
            this.inputGravedad.Location = new System.Drawing.Point(20, 365);
            this.inputGravedad.Name = "inputGravedad";
            this.inputGravedad.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inputGravedad.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputGravedad.SetEnable = true;
            this.inputGravedad.SetEnableClick = false;
            this.inputGravedad.SetImageIcon = null;
            this.inputGravedad.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.inputGravedad.SetSizeInput = 12F;
            this.inputGravedad.SetSizeLabel = 10F;
            this.inputGravedad.SetTextInput = "9.8";
            this.inputGravedad.SetTextlabel = "Gravedad -> g";
            this.inputGravedad.SetWidthIcon = 20;
            this.inputGravedad.Size = new System.Drawing.Size(203, 63);
            this.inputGravedad.TabIndex = 11;
            // 
            // inpAltura
            // 
            this.inpAltura.Location = new System.Drawing.Point(20, 20);
            this.inpAltura.Name = "inpAltura";
            this.inpAltura.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inpAltura.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inpAltura.SetEnable = true;
            this.inpAltura.SetEnableClick = false;
            this.inpAltura.SetImageIcon = null;
            this.inpAltura.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.inpAltura.SetSizeInput = 12F;
            this.inpAltura.SetSizeLabel = 10F;
            this.inpAltura.SetTextInput = "";
            this.inpAltura.SetTextlabel = "Altura -> h";
            this.inpAltura.SetWidthIcon = 20;
            this.inpAltura.Size = new System.Drawing.Size(203, 63);
            this.inpAltura.TabIndex = 5;
            // 
            // btnCalcu
            // 
            this.btnCalcu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcu.Location = new System.Drawing.Point(47, 438);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Padding = new System.Windows.Forms.Padding(5);
            this.btnCalcu.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCalcu.SetImageIcon = null;
            this.btnCalcu.SetOnClick = null;
            this.btnCalcu.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.btnCalcu.SetSizeText = 12F;
            this.btnCalcu.SetText = "Calcular";
            this.btnCalcu.SetTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcu.SetWidthIcon = 30;
            this.btnCalcu.Size = new System.Drawing.Size(134, 37);
            this.btnCalcu.TabIndex = 10;
            // 
            // inpTiempo
            // 
            this.inpTiempo.Location = new System.Drawing.Point(20, 89);
            this.inpTiempo.Name = "inpTiempo";
            this.inpTiempo.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inpTiempo.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inpTiempo.SetEnable = true;
            this.inpTiempo.SetEnableClick = false;
            this.inpTiempo.SetImageIcon = null;
            this.inpTiempo.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.inpTiempo.SetSizeInput = 12F;
            this.inpTiempo.SetSizeLabel = 10F;
            this.inpTiempo.SetTextInput = "";
            this.inpTiempo.SetTextlabel = "Tiempo -> t";
            this.inpTiempo.SetWidthIcon = 20;
            this.inpTiempo.Size = new System.Drawing.Size(203, 63);
            this.inpTiempo.TabIndex = 6;
            // 
            // inpVeFin
            // 
            this.inpVeFin.Location = new System.Drawing.Point(20, 158);
            this.inpVeFin.Name = "inpVeFin";
            this.inpVeFin.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inpVeFin.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inpVeFin.SetEnable = true;
            this.inpVeFin.SetEnableClick = false;
            this.inpVeFin.SetImageIcon = null;
            this.inpVeFin.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.inpVeFin.SetSizeInput = 12F;
            this.inpVeFin.SetSizeLabel = 10F;
            this.inpVeFin.SetTextInput = "";
            this.inpVeFin.SetTextlabel = "Velocidad Final -> Vf";
            this.inpVeFin.SetWidthIcon = 20;
            this.inpVeFin.Size = new System.Drawing.Size(203, 63);
            this.inpVeFin.TabIndex = 7;
            // 
            // inpVeIMed
            // 
            this.inpVeIMed.Location = new System.Drawing.Point(20, 296);
            this.inpVeIMed.Name = "inpVeIMed";
            this.inpVeIMed.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inpVeIMed.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inpVeIMed.SetEnable = true;
            this.inpVeIMed.SetEnableClick = false;
            this.inpVeIMed.SetImageIcon = null;
            this.inpVeIMed.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.inpVeIMed.SetSizeInput = 12F;
            this.inpVeIMed.SetSizeLabel = 10F;
            this.inpVeIMed.SetTextInput = "";
            this.inpVeIMed.SetTextlabel = "Velocidad Media -> Vm";
            this.inpVeIMed.SetWidthIcon = 20;
            this.inpVeIMed.Size = new System.Drawing.Size(203, 63);
            this.inpVeIMed.TabIndex = 8;
            // 
            // inpVeIni
            // 
            this.inpVeIni.Location = new System.Drawing.Point(20, 227);
            this.inpVeIni.Name = "inpVeIni";
            this.inpVeIni.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inpVeIni.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inpVeIni.SetEnable = true;
            this.inpVeIni.SetEnableClick = false;
            this.inpVeIni.SetImageIcon = null;
            this.inpVeIni.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.inpVeIni.SetSizeInput = 12F;
            this.inpVeIni.SetSizeLabel = 10F;
            this.inpVeIni.SetTextInput = "0";
            this.inpVeIni.SetTextlabel = "Velocidad Inicial -> Vo";
            this.inpVeIni.SetWidthIcon = 20;
            this.inpVeIni.Size = new System.Drawing.Size(203, 63);
            this.inpVeIni.TabIndex = 8;
            // 
            // CaidaLibreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 591);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaidaLibreForm";
            this.Text = "CaidaLibreForm";
            this.Load += new System.EventHandler(this.CaidaLibreForm_Load);
            this.header.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResultBack.ResumeLayout(false);
            this.panelResultBack.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panel2;
        private ControlComponents.Component.Inputs.InputDefault inpAltura;
        private ControlComponents.Component.ButtonIcon btnCalcu;
        private ControlComponents.Component.Inputs.InputDefault inpTiempo;
        private ControlComponents.Component.Inputs.InputDefault inpVeFin;
        private ControlComponents.Component.Inputs.InputDefault inpVeIni;
        private System.Windows.Forms.Panel panelResultBack;
        private System.Windows.Forms.TextBox txtResult;
        private ControlComponents.Component.Inputs.InputDefault inpVeIMed;
        private ControlComponents.Component.Inputs.InputList inputSelect;
        private ControlComponents.Component.Inputs.InputDefault inputGravedad;
        private System.Windows.Forms.PictureBox btnLimpiar;
    }
}