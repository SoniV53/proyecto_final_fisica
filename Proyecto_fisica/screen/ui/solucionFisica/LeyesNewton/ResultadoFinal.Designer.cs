namespace Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton
{
    partial class ResultadoFinal
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
            this.txtExtras = new System.Windows.Forms.Label();
            this.txtResultY = new System.Windows.Forms.Label();
            this.txtResultX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExtras
            // 
            this.txtExtras.BackColor = System.Drawing.Color.White;
            this.txtExtras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtras.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtExtras.Location = new System.Drawing.Point(5, 268);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Padding = new System.Windows.Forms.Padding(5);
            this.txtExtras.Size = new System.Drawing.Size(550, 81);
            this.txtExtras.TabIndex = 2;
            // 
            // txtResultY
            // 
            this.txtResultY.BackColor = System.Drawing.Color.White;
            this.txtResultY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultY.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtResultY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultY.Location = new System.Drawing.Point(282, 5);
            this.txtResultY.Name = "txtResultY";
            this.txtResultY.Padding = new System.Windows.Forms.Padding(5);
            this.txtResultY.Size = new System.Drawing.Size(273, 263);
            this.txtResultY.TabIndex = 3;
            // 
            // txtResultX
            // 
            this.txtResultX.BackColor = System.Drawing.Color.White;
            this.txtResultX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultX.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtResultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultX.Location = new System.Drawing.Point(5, 5);
            this.txtResultX.Name = "txtResultX";
            this.txtResultX.Padding = new System.Windows.Forms.Padding(5);
            this.txtResultX.Size = new System.Drawing.Size(273, 263);
            this.txtResultX.TabIndex = 4;
            // 
            // ResultadoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(560, 354);
            this.Controls.Add(this.txtResultX);
            this.Controls.Add(this.txtResultY);
            this.Controls.Add(this.txtExtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResultadoFinal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoFinal";
            this.Load += new System.EventHandler(this.ResultadoFinal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtExtras;
        private System.Windows.Forms.Label txtResultY;
        private System.Windows.Forms.Label txtResultX;
    }
}