namespace Final_Proyecto_1
{
    partial class Rectangulo
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
            this.btnRegresarRectangulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoR = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblResultadoRectangulo = new System.Windows.Forms.Label();
            this.btnCalculaRectangulo = new System.Windows.Forms.Button();
            this.numBaseRectangulo = new System.Windows.Forms.NumericUpDown();
            this.lblAltura = new System.Windows.Forms.Label();
            this.numAlturaRectangulo = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseRectangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlturaRectangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarRectangulo
            // 
            this.btnRegresarRectangulo.BackColor = System.Drawing.Color.Tomato;
            this.btnRegresarRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarRectangulo.Location = new System.Drawing.Point(301, 294);
            this.btnRegresarRectangulo.Name = "btnRegresarRectangulo";
            this.btnRegresarRectangulo.Size = new System.Drawing.Size(155, 32);
            this.btnRegresarRectangulo.TabIndex = 17;
            this.btnRegresarRectangulo.Text = "Regresar";
            this.btnRegresarRectangulo.UseVisualStyleBackColor = false;
            this.btnRegresarRectangulo.Click += new System.EventHandler(this.btnRegresarRectangulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rectangulo";
            // 
            // lblResultadoR
            // 
            this.lblResultadoR.AutoSize = true;
            this.lblResultadoR.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoR.Location = new System.Drawing.Point(58, 266);
            this.lblResultadoR.Name = "lblResultadoR";
            this.lblResultadoR.Size = new System.Drawing.Size(92, 22);
            this.lblResultadoR.TabIndex = 14;
            this.lblResultadoR.Text = "Resultado:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(58, 120);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(54, 22);
            this.lblBase.TabIndex = 13;
            this.lblBase.Text = "Base:";
            // 
            // lblResultadoRectangulo
            // 
            this.lblResultadoRectangulo.AutoSize = true;
            this.lblResultadoRectangulo.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoRectangulo.Location = new System.Drawing.Point(193, 266);
            this.lblResultadoRectangulo.Name = "lblResultadoRectangulo";
            this.lblResultadoRectangulo.Size = new System.Drawing.Size(28, 22);
            this.lblResultadoRectangulo.TabIndex = 12;
            this.lblResultadoRectangulo.Text = "...";
            // 
            // btnCalculaRectangulo
            // 
            this.btnCalculaRectangulo.BackColor = System.Drawing.Color.Tomato;
            this.btnCalculaRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaRectangulo.Location = new System.Drawing.Point(62, 217);
            this.btnCalculaRectangulo.Name = "btnCalculaRectangulo";
            this.btnCalculaRectangulo.Size = new System.Drawing.Size(218, 32);
            this.btnCalculaRectangulo.TabIndex = 11;
            this.btnCalculaRectangulo.Text = "Calcular";
            this.btnCalculaRectangulo.UseVisualStyleBackColor = false;
            this.btnCalculaRectangulo.Click += new System.EventHandler(this.btnCalculaRectangulo_Click);
            // 
            // numBaseRectangulo
            // 
            this.numBaseRectangulo.DecimalPlaces = 3;
            this.numBaseRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBaseRectangulo.Location = new System.Drawing.Point(135, 113);
            this.numBaseRectangulo.Name = "numBaseRectangulo";
            this.numBaseRectangulo.Size = new System.Drawing.Size(120, 29);
            this.numBaseRectangulo.TabIndex = 10;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(58, 163);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(61, 22);
            this.lblAltura.TabIndex = 19;
            this.lblAltura.Text = "Altura:";
            // 
            // numAlturaRectangulo
            // 
            this.numAlturaRectangulo.DecimalPlaces = 3;
            this.numAlturaRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAlturaRectangulo.Location = new System.Drawing.Point(135, 163);
            this.numAlturaRectangulo.Name = "numAlturaRectangulo";
            this.numAlturaRectangulo.Size = new System.Drawing.Size(120, 29);
            this.numAlturaRectangulo.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Proyecto_1.Properties.Resources.Rectángulo;
            this.pictureBox1.Location = new System.Drawing.Point(301, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(503, 338);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.numAlturaRectangulo);
            this.Controls.Add(this.btnRegresarRectangulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoR);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblResultadoRectangulo);
            this.Controls.Add(this.btnCalculaRectangulo);
            this.Controls.Add(this.numBaseRectangulo);
            this.Name = "Rectangulo";
            this.Text = "Rectangulo";
            ((System.ComponentModel.ISupportInitialize)(this.numBaseRectangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlturaRectangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarRectangulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoR;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblResultadoRectangulo;
        private System.Windows.Forms.Button btnCalculaRectangulo;
        private System.Windows.Forms.NumericUpDown numBaseRectangulo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.NumericUpDown numAlturaRectangulo;
    }
}