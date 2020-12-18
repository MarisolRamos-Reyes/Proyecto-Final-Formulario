namespace Final_Proyecto_1
{
    partial class Circulo
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
            this.btnRegresarCirculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoCir = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblResultadoCirculo = new System.Windows.Forms.Label();
            this.btnCalculaCirculo = new System.Windows.Forms.Button();
            this.numRadioCirculo = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRadioCirculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarCirculo
            // 
            this.btnRegresarCirculo.BackColor = System.Drawing.Color.Lime;
            this.btnRegresarCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarCirculo.Location = new System.Drawing.Point(284, 285);
            this.btnRegresarCirculo.Name = "btnRegresarCirculo";
            this.btnRegresarCirculo.Size = new System.Drawing.Size(155, 32);
            this.btnRegresarCirculo.TabIndex = 27;
            this.btnRegresarCirculo.Text = "Regresar";
            this.btnRegresarCirculo.UseVisualStyleBackColor = false;
            this.btnRegresarCirculo.Click += new System.EventHandler(this.btnRegresarCirculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "Circulo";
            // 
            // lblResultadoCir
            // 
            this.lblResultadoCir.AutoSize = true;
            this.lblResultadoCir.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCir.Location = new System.Drawing.Point(52, 223);
            this.lblResultadoCir.Name = "lblResultadoCir";
            this.lblResultadoCir.Size = new System.Drawing.Size(92, 22);
            this.lblResultadoCir.TabIndex = 24;
            this.lblResultadoCir.Text = "Resultado:";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadio.Location = new System.Drawing.Point(52, 116);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(61, 22);
            this.lblRadio.TabIndex = 23;
            this.lblRadio.Text = "Radio:";
            // 
            // lblResultadoCirculo
            // 
            this.lblResultadoCirculo.AutoSize = true;
            this.lblResultadoCirculo.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCirculo.Location = new System.Drawing.Point(187, 223);
            this.lblResultadoCirculo.Name = "lblResultadoCirculo";
            this.lblResultadoCirculo.Size = new System.Drawing.Size(28, 22);
            this.lblResultadoCirculo.TabIndex = 22;
            this.lblResultadoCirculo.Text = "...";
            // 
            // btnCalculaCirculo
            // 
            this.btnCalculaCirculo.BackColor = System.Drawing.Color.Lime;
            this.btnCalculaCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaCirculo.Location = new System.Drawing.Point(56, 174);
            this.btnCalculaCirculo.Name = "btnCalculaCirculo";
            this.btnCalculaCirculo.Size = new System.Drawing.Size(218, 32);
            this.btnCalculaCirculo.TabIndex = 21;
            this.btnCalculaCirculo.Text = "Calcular";
            this.btnCalculaCirculo.UseVisualStyleBackColor = false;
            this.btnCalculaCirculo.Click += new System.EventHandler(this.btnCalculaCirculo_Click);
            // 
            // numRadioCirculo
            // 
            this.numRadioCirculo.DecimalPlaces = 3;
            this.numRadioCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRadioCirculo.Location = new System.Drawing.Point(129, 109);
            this.numRadioCirculo.Name = "numRadioCirculo";
            this.numRadioCirculo.Size = new System.Drawing.Size(120, 29);
            this.numRadioCirculo.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Proyecto_1.Properties.Resources.Circulo;
            this.pictureBox1.Location = new System.Drawing.Point(309, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(245)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(451, 341);
            this.Controls.Add(this.btnRegresarCirculo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoCir);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblResultadoCirculo);
            this.Controls.Add(this.btnCalculaCirculo);
            this.Controls.Add(this.numRadioCirculo);
            this.Name = "Circulo";
            this.Text = "Circulo";
            ((System.ComponentModel.ISupportInitialize)(this.numRadioCirculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresarCirculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoCir;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblResultadoCirculo;
        private System.Windows.Forms.Button btnCalculaCirculo;
        private System.Windows.Forms.NumericUpDown numRadioCirculo;
    }
}