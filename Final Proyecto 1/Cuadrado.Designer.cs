namespace Final_Proyecto_1
{
    partial class Cuadrado
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
            this.numBaseCuadrado = new System.Windows.Forms.NumericUpDown();
            this.btnCalculaCuadrado = new System.Windows.Forms.Button();
            this.lblResultadoCuadrado = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblResultadoC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresarCuadrado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numBaseCuadrado
            // 
            this.numBaseCuadrado.DecimalPlaces = 3;
            this.numBaseCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBaseCuadrado.Location = new System.Drawing.Point(170, 112);
            this.numBaseCuadrado.Name = "numBaseCuadrado";
            this.numBaseCuadrado.Size = new System.Drawing.Size(120, 29);
            this.numBaseCuadrado.TabIndex = 0;
            // 
            // btnCalculaCuadrado
            // 
            this.btnCalculaCuadrado.BackColor = System.Drawing.Color.Violet;
            this.btnCalculaCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaCuadrado.Location = new System.Drawing.Point(97, 171);
            this.btnCalculaCuadrado.Name = "btnCalculaCuadrado";
            this.btnCalculaCuadrado.Size = new System.Drawing.Size(218, 32);
            this.btnCalculaCuadrado.TabIndex = 2;
            this.btnCalculaCuadrado.Text = "Calcular";
            this.btnCalculaCuadrado.UseVisualStyleBackColor = false;
            this.btnCalculaCuadrado.Click += new System.EventHandler(this.btnCalculaCuadrado_Click);
            // 
            // lblResultadoCuadrado
            // 
            this.lblResultadoCuadrado.AutoSize = true;
            this.lblResultadoCuadrado.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCuadrado.Location = new System.Drawing.Point(232, 223);
            this.lblResultadoCuadrado.Name = "lblResultadoCuadrado";
            this.lblResultadoCuadrado.Size = new System.Drawing.Size(28, 22);
            this.lblResultadoCuadrado.TabIndex = 3;
            this.lblResultadoCuadrado.Text = "...";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(93, 119);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(54, 22);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Lado:";
            // 
            // lblResultadoC
            // 
            this.lblResultadoC.AutoSize = true;
            this.lblResultadoC.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoC.Location = new System.Drawing.Point(93, 223);
            this.lblResultadoC.Name = "lblResultadoC";
            this.lblResultadoC.Size = new System.Drawing.Size(92, 22);
            this.lblResultadoC.TabIndex = 6;
            this.lblResultadoC.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(160)))), ((int)(((byte)(243)))));
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(150, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cuadrado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Proyecto_1.Properties.Resources.CUADRADO_2;
            this.pictureBox1.Location = new System.Drawing.Point(339, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresarCuadrado
            // 
            this.btnRegresarCuadrado.BackColor = System.Drawing.Color.Violet;
            this.btnRegresarCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarCuadrado.Location = new System.Drawing.Point(287, 265);
            this.btnRegresarCuadrado.Name = "btnRegresarCuadrado";
            this.btnRegresarCuadrado.Size = new System.Drawing.Size(155, 32);
            this.btnRegresarCuadrado.TabIndex = 9;
            this.btnRegresarCuadrado.Text = "Regresar";
            this.btnRegresarCuadrado.UseVisualStyleBackColor = false;
            this.btnRegresarCuadrado.Click += new System.EventHandler(this.btnRegresarCuadrado_Click);
            // 
            // Cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(467, 309);
            this.Controls.Add(this.btnRegresarCuadrado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoC);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblResultadoCuadrado);
            this.Controls.Add(this.btnCalculaCuadrado);
            this.Controls.Add(this.numBaseCuadrado);
            this.Name = "Cuadrado";
            this.Text = "Cuadrado";
            ((System.ComponentModel.ISupportInitialize)(this.numBaseCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBaseCuadrado;
        private System.Windows.Forms.Button btnCalculaCuadrado;
        private System.Windows.Forms.Label lblResultadoCuadrado;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblResultadoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarCuadrado;
    }
}