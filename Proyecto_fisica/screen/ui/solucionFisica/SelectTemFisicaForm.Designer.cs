namespace Proyecto_fisica.screen.ui.solucionFisica
{
    partial class SelectTemFisicaForm
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
            this.cardNewton = new ControlComponents.Component.Cards.CardInformation();
            this.cardInformation3 = new ControlComponents.Component.Cards.CardInformation();
            this.cardCaida = new ControlComponents.Component.Cards.CardInformation();
            this.cardInformation1 = new ControlComponents.Component.Cards.CardInformation();
            this.header.SuspendLayout();
            this.body.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(769, 104);
            this.header.TabIndex = 0;
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
            this.label1.Text = "Seleccione Tema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // body
            // 
            this.body.Controls.Add(this.cardNewton);
            this.body.Controls.Add(this.cardInformation3);
            this.body.Controls.Add(this.cardCaida);
            this.body.Controls.Add(this.cardInformation1);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 104);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(769, 487);
            this.body.TabIndex = 1;
            // 
            // cardNewton
            // 
            this.cardNewton.BackColor = System.Drawing.Color.DarkCyan;
            this.cardNewton.Location = new System.Drawing.Point(444, 159);
            this.cardNewton.Name = "cardNewton";
            this.cardNewton.SetColorBackImage = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.cardNewton.SetColorButton = System.Drawing.Color.MediumTurquoise;
            this.cardNewton.SetColorTextButton = System.Drawing.Color.DarkBlue;
            this.cardNewton.SetImageHead = global::Proyecto_fisica.Properties.Resources.newton_white;
            this.cardNewton.SetOnClick = null;
            this.cardNewton.SetOnClickPanel = null;
            this.cardNewton.SetSizeButton = 0;
            this.cardNewton.SetSizeImageHead = new System.Drawing.Size(0, 90);
            this.cardNewton.SetSizeTextButton = 12F;
            this.cardNewton.SetTextButton = "Continuar";
            this.cardNewton.Size = new System.Drawing.Size(207, 157);
            this.cardNewton.TabIndex = 12;
            // 
            // cardInformation3
            // 
            this.cardInformation3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cardInformation3.Location = new System.Drawing.Point(453, 169);
            this.cardInformation3.Name = "cardInformation3";
            this.cardInformation3.SetColorBackImage = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.cardInformation3.SetColorButton = System.Drawing.Color.MediumTurquoise;
            this.cardInformation3.SetColorTextButton = System.Drawing.Color.DarkBlue;
            this.cardInformation3.SetImageHead = null;
            this.cardInformation3.SetOnClick = null;
            this.cardInformation3.SetOnClickPanel = null;
            this.cardInformation3.SetSizeButton = 0;
            this.cardInformation3.SetSizeImageHead = new System.Drawing.Size(0, 90);
            this.cardInformation3.SetSizeTextButton = 12F;
            this.cardInformation3.SetTextButton = "Continuar";
            this.cardInformation3.Size = new System.Drawing.Size(207, 157);
            this.cardInformation3.TabIndex = 11;
            // 
            // cardCaida
            // 
            this.cardCaida.BackColor = System.Drawing.Color.DarkCyan;
            this.cardCaida.Location = new System.Drawing.Point(81, 159);
            this.cardCaida.Name = "cardCaida";
            this.cardCaida.SetColorBackImage = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.cardCaida.SetColorButton = System.Drawing.Color.MediumTurquoise;
            this.cardCaida.SetColorTextButton = System.Drawing.Color.DarkBlue;
            this.cardCaida.SetImageHead = global::Proyecto_fisica.Properties.Resources.caida_libre_white;
            this.cardCaida.SetOnClick = null;
            this.cardCaida.SetOnClickPanel = null;
            this.cardCaida.SetSizeButton = 0;
            this.cardCaida.SetSizeImageHead = new System.Drawing.Size(0, 90);
            this.cardCaida.SetSizeTextButton = 12F;
            this.cardCaida.SetTextButton = "Continuar";
            this.cardCaida.Size = new System.Drawing.Size(207, 157);
            this.cardCaida.TabIndex = 10;
            // 
            // cardInformation1
            // 
            this.cardInformation1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cardInformation1.Location = new System.Drawing.Point(90, 169);
            this.cardInformation1.Name = "cardInformation1";
            this.cardInformation1.SetColorBackImage = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.cardInformation1.SetColorButton = System.Drawing.Color.MediumTurquoise;
            this.cardInformation1.SetColorTextButton = System.Drawing.Color.DarkBlue;
            this.cardInformation1.SetImageHead = null;
            this.cardInformation1.SetOnClick = null;
            this.cardInformation1.SetOnClickPanel = null;
            this.cardInformation1.SetSizeButton = 0;
            this.cardInformation1.SetSizeImageHead = new System.Drawing.Size(0, 90);
            this.cardInformation1.SetSizeTextButton = 12F;
            this.cardInformation1.SetTextButton = "Continuar";
            this.cardInformation1.Size = new System.Drawing.Size(207, 157);
            this.cardInformation1.TabIndex = 9;
            // 
            // SelectTemFisicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 591);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectTemFisicaForm";
            this.Text = "SelectTemFisicaForm";
            this.Load += new System.EventHandler(this.SelectTemFisicaForm_Load);
            this.header.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Label label1;
        private ControlComponents.Component.Cards.CardInformation cardInformation1;
        private ControlComponents.Component.Cards.CardInformation cardCaida;
        private ControlComponents.Component.Cards.CardInformation cardNewton;
        private ControlComponents.Component.Cards.CardInformation cardInformation3;
    }
}