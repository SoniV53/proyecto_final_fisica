namespace Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton
{
    partial class DeleteInputsSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteInputsSelect));
            this.inputList1 = new ControlComponents.Component.Inputs.InputList();
            this.btnAdd = new ControlComponents.Component.ButtonIcon();
            this.SuspendLayout();
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
            this.inputList1.SetTextlabel = "Seleccione Item a eliminar:";
            this.inputList1.Size = new System.Drawing.Size(243, 59);
            this.inputList1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(63, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.SetColorText = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdd.SetImageIcon = null;
            this.btnAdd.SetOnClick = null;
            this.btnAdd.SetPositionIcon = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.SetSizeText = 10F;
            this.btnAdd.SetText = "Eliminar";
            this.btnAdd.SetTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.SetWidthIcon = 30;
            this.btnAdd.Size = new System.Drawing.Size(127, 35);
            this.btnAdd.TabIndex = 39;
            // 
            // DeleteInputsSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 120);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inputList1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteInputsSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.DeleteInputsSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlComponents.Component.Inputs.InputList inputList1;
        private ControlComponents.Component.ButtonIcon btnAdd;
    }
}