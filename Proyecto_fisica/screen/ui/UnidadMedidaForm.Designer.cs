namespace Proyecto_fisica.screen.ui
{
    partial class UnidadMedidaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.Label();
            this.inputNum = new ControlComponents.Component.Inputs.InputDefault();
            this.inputSelect1 = new ControlComponents.Component.Inputs.InputList();
            this.rbLongitud = new System.Windows.Forms.RadioButton();
            this.rbTiempo = new System.Windows.Forms.RadioButton();
            this.rbMasa = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.btnConver = new ControlComponents.Component.ButtonIcon();
            this.inputSelect2 = new ControlComponents.Component.Inputs.InputList();
            this.body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 87);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidad de Medida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // body
            // 
            this.body.Controls.Add(this.txtMessage);
            this.body.Controls.Add(this.inputNum);
            this.body.Controls.Add(this.inputSelect1);
            this.body.Controls.Add(this.rbLongitud);
            this.body.Controls.Add(this.rbTiempo);
            this.body.Controls.Add(this.rbMasa);
            this.body.Controls.Add(this.panel1);
            this.body.Controls.Add(this.lbA);
            this.body.Controls.Add(this.btnConver);
            this.body.Controls.Add(this.inputSelect2);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 87);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(769, 504);
            this.body.TabIndex = 6;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.Maroon;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(31, 425);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(235, 55);
            this.txtMessage.TabIndex = 10;
            this.txtMessage.Text = "Ingrese un número valido";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputNum
            // 
            this.inputNum.Location = new System.Drawing.Point(55, 119);
            this.inputNum.Name = "inputNum";
            this.inputNum.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inputNum.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputNum.SetEnable = true;
            this.inputNum.SetImageIcon = null;
            this.inputNum.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.inputNum.SetSizeInput = 12F;
            this.inputNum.SetSizeLabel = 10F;
            this.inputNum.SetTextInput = "";
            this.inputNum.SetTextlabel = "Ingrese Número";
            this.inputNum.SetWidthIcon = 20;
            this.inputNum.Size = new System.Drawing.Size(253, 63);
            this.inputNum.TabIndex = 9;
            // 
            // inputSelect1
            // 
            this.inputSelect1.Location = new System.Drawing.Point(51, 223);
            this.inputSelect1.Name = "inputSelect1";
            this.inputSelect1.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inputSelect1.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputSelect1.SetEventAction = null;
            this.inputSelect1.SetItems = new string[] {
        ""};
            this.inputSelect1.SetSizeInput = 12F;
            this.inputSelect1.SetSizeLabel = 10F;
            this.inputSelect1.SetTextInput = "";
            this.inputSelect1.SetTextlabel = "Seleccione unidad de medida";
            this.inputSelect1.Size = new System.Drawing.Size(258, 62);
            this.inputSelect1.TabIndex = 7;
            // 
            // rbLongitud
            // 
            this.rbLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLongitud.Location = new System.Drawing.Point(376, 40);
            this.rbLongitud.Name = "rbLongitud";
            this.rbLongitud.Size = new System.Drawing.Size(150, 47);
            this.rbLongitud.TabIndex = 6;
            this.rbLongitud.Text = "Longitud";
            this.rbLongitud.UseVisualStyleBackColor = true;
            this.rbLongitud.CheckedChanged += new System.EventHandler(this.rbLongitud_CheckedChanged);
            // 
            // rbTiempo
            // 
            this.rbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTiempo.Location = new System.Drawing.Point(211, 40);
            this.rbTiempo.Name = "rbTiempo";
            this.rbTiempo.Size = new System.Drawing.Size(150, 47);
            this.rbTiempo.TabIndex = 6;
            this.rbTiempo.Text = "Tiempo";
            this.rbTiempo.UseVisualStyleBackColor = true;
            this.rbTiempo.CheckedChanged += new System.EventHandler(this.rbTiempo_CheckedChanged);
            // 
            // rbMasa
            // 
            this.rbMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasa.Location = new System.Drawing.Point(55, 40);
            this.rbMasa.Name = "rbMasa";
            this.rbMasa.Size = new System.Drawing.Size(150, 47);
            this.rbMasa.TabIndex = 6;
            this.rbMasa.Text = "Masa";
            this.rbMasa.UseVisualStyleBackColor = true;
            this.rbMasa.CheckedChanged += new System.EventHandler(this.rbMasa_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelResult);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(456, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 63);
            this.panel1.TabIndex = 5;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.White;
            this.panelResult.Controls.Add(this.txtResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(0, 20);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(259, 43);
            this.panelResult.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(3, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(253, 19);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResult_KeyPress);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(361, 200);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(31, 36);
            this.lbA.TabIndex = 4;
            this.lbA.Text = "A";
            // 
            // btnConver
            // 
            this.btnConver.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConver.Location = new System.Drawing.Point(239, 334);
            this.btnConver.Name = "btnConver";
            this.btnConver.Padding = new System.Windows.Forms.Padding(5);
            this.btnConver.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnConver.SetImageIcon = null;
            this.btnConver.SetOnClick = null;
            this.btnConver.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.btnConver.SetSizeText = 12F;
            this.btnConver.SetText = "Convertir";
            this.btnConver.SetTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConver.SetWidthIcon = 30;
            this.btnConver.Size = new System.Drawing.Size(248, 55);
            this.btnConver.TabIndex = 3;
            // 
            // inputSelect2
            // 
            this.inputSelect2.Location = new System.Drawing.Point(456, 223);
            this.inputSelect2.Name = "inputSelect2";
            this.inputSelect2.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inputSelect2.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputSelect2.SetEventAction = null;
            this.inputSelect2.SetItems = new string[] {
        ""};
            this.inputSelect2.SetSizeInput = 12F;
            this.inputSelect2.SetSizeLabel = 10F;
            this.inputSelect2.SetTextInput = "";
            this.inputSelect2.SetTextlabel = "Seleccione unidad de medida";
            this.inputSelect2.Size = new System.Drawing.Size(258, 62);
            this.inputSelect2.TabIndex = 2;
            // 
            // UnidadMedidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(769, 591);
            this.Controls.Add(this.body);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnidadMedidaForm";
            this.Text = "UnidadMedidaForm";
            this.Load += new System.EventHandler(this.UnidadMedidaForm_Load);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Label lbA;
        private ControlComponents.Component.ButtonIcon btnConver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMasa;
        private System.Windows.Forms.RadioButton rbLongitud;
        private System.Windows.Forms.RadioButton rbTiempo;
        private ControlComponents.Component.Inputs.InputList inputSelect1;
        private ControlComponents.Component.Inputs.InputDefault inputNum;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.TextBox txtResult;
        private ControlComponents.Component.Inputs.InputList inputSelect2;
    }
}