namespace Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton
{
    partial class AgregarInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarInput));
            this.checkGrado = new System.Windows.Forms.CheckBox();
            this.pnSenCos = new System.Windows.Forms.Panel();
            this.raCos = new System.Windows.Forms.RadioButton();
            this.raSen = new System.Windows.Forms.RadioButton();
            this.btnAdd = new ControlComponents.Component.ButtonIcon();
            this.inputList1 = new ControlComponents.Component.Inputs.InputList();
            this.pnSenCos.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkGrado
            // 
            this.checkGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGrado.Location = new System.Drawing.Point(12, 79);
            this.checkGrado.Name = "checkGrado";
            this.checkGrado.Size = new System.Drawing.Size(130, 48);
            this.checkGrado.TabIndex = 3;
            this.checkGrado.Text = "Grado";
            this.checkGrado.UseVisualStyleBackColor = true;
            this.checkGrado.Click += new System.EventHandler(this.checkGrado_Click);
            // 
            // pnSenCos
            // 
            this.pnSenCos.Controls.Add(this.raCos);
            this.pnSenCos.Controls.Add(this.raSen);
            this.pnSenCos.Location = new System.Drawing.Point(209, 79);
            this.pnSenCos.Name = "pnSenCos";
            this.pnSenCos.Size = new System.Drawing.Size(139, 48);
            this.pnSenCos.TabIndex = 4;
            // 
            // raCos
            // 
            this.raCos.AutoSize = true;
            this.raCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raCos.Location = new System.Drawing.Point(72, 13);
            this.raCos.Name = "raCos";
            this.raCos.Size = new System.Drawing.Size(64, 24);
            this.raCos.TabIndex = 1;
            this.raCos.TabStop = true;
            this.raCos.Text = "COS";
            this.raCos.UseVisualStyleBackColor = true;
            // 
            // raSen
            // 
            this.raSen.AutoSize = true;
            this.raSen.Checked = true;
            this.raSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raSen.Location = new System.Drawing.Point(3, 13);
            this.raSen.Name = "raSen";
            this.raSen.Size = new System.Drawing.Size(63, 24);
            this.raSen.TabIndex = 0;
            this.raSen.TabStop = true;
            this.raSen.Text = "SEN";
            this.raSen.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(75, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdd.SetImageIcon = null;
            this.btnAdd.SetOnClick = null;
            this.btnAdd.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.SetSizeText = 10F;
            this.btnAdd.SetText = "Agregar";
            this.btnAdd.SetTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.SetWidthIcon = 30;
            this.btnAdd.Size = new System.Drawing.Size(200, 42);
            this.btnAdd.TabIndex = 38;
            // 
            // inputList1
            // 
            this.inputList1.Location = new System.Drawing.Point(12, 12);
            this.inputList1.Name = "inputList1";
            this.inputList1.SeleccIndex = -1;
            this.inputList1.SetAlignmentLabel = System.Drawing.ContentAlignment.BottomLeft;
            this.inputList1.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inputList1.SetEnableClick = true;
            this.inputList1.SetEventAction = null;
            this.inputList1.SetEventActionPos = null;
            this.inputList1.SetItems = new string[] {
        ""};
            this.inputList1.SetSizeInput = 12F;
            this.inputList1.SetSizeLabel = 10F;
            this.inputList1.SetTextInput = "";
            this.inputList1.SetTextlabel = "Seleccione Valor";
            this.inputList1.Size = new System.Drawing.Size(336, 59);
            this.inputList1.TabIndex = 2;
            // 
            // AgregarInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 191);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnSenCos);
            this.Controls.Add(this.checkGrado);
            this.Controls.Add(this.inputList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AgregarInput_Load);
            this.pnSenCos.ResumeLayout(false);
            this.pnSenCos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlComponents.Component.Inputs.InputList inputList1;
        private System.Windows.Forms.CheckBox checkGrado;
        private System.Windows.Forms.Panel pnSenCos;
        private System.Windows.Forms.RadioButton raCos;
        private System.Windows.Forms.RadioButton raSen;
        private ControlComponents.Component.ButtonIcon btnAdd;
    }
}