namespace Final_Proyecto_1
{
    partial class Trapecio
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
            this.btnRegresarTrapecio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoTr = new System.Windows.Forms.Label();
            this.lblBaseMayorTrapecio = new System.Windows.Forms.Label();
            this.lblResultadoTrapecio = new System.Windows.Forms.Label();
            this.btnCalculaTrapecio = new System.Windows.Forms.Button();
            this.numBaseMayorTrapecio = new System.Windows.Forms.NumericUpDown();
            this.lblBaseMenorTrapecio = new System.Windows.Forms.Label();
            this.numBaseMenorTrapecio = new System.Windows.Forms.NumericUpDown();
            this.lblLadoTrapecio = new System.Windows.Forms.Label();
            this.numLadoTrapecio = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseMayorTrapecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseMenorTrapecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLadoTrapecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarTrapecio
            // 
            this.btnRegresarTrapecio.BackColor = System.Drawing.Color.Blue;
            this.btnRegresarTrapecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarTrapecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresarTrapecio.Location = new System.Drawing.Point(299, 355);
            this.btnRegresarTrapecio.Name = "btnRegresarTrapecio";
            this.btnRegresarTrapecio.Size = new System.Drawing.Size(155, 32);
            this.btnRegresarTrapecio.TabIndex = 27;
            this.btnRegresarTrapecio.Text = "Regresar";
            this.btnRegresarTrapecio.UseVisualStyleBackColor = false;
            this.btnRegresarTrapecio.Click += new System.EventHandler(this.btnRegresarTrapecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(165, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "Trapecio";
            // 
            // lblResultadoTr
            // 
            this.lblResultadoTr.AutoSize = true;
            this.lblResultadoTr.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTr.Location = new System.Drawing.Point(56, 327);
            this.lblResultadoTr.Name = "lblResultadoTr";
            this.lblResultadoTr.Size = new System.Drawing.Size(92, 22);
            this.lblResultadoTr.TabIndex = 24;
            this.lblResultadoTr.Text = "Resultado:";
            // 
            // lblBaseMayorTrapecio
            // 
            this.lblBaseMayorTrapecio.AutoSize = true;
            this.lblBaseMayorTrapecio.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMayorTrapecio.Location = new System.Drawing.Point(56, 123);
            this.lblBaseMayorTrapecio.Name = "lblBaseMayorTrapecio";
            this.lblBaseMayorTrapecio.Size = new System.Drawing.Size(109, 22);
            this.lblBaseMayorTrapecio.TabIndex = 23;
            this.lblBaseMayorTrapecio.Text = "Base Mayor:";
            // 
            // lblResultadoTrapecio
            // 
            this.lblResultadoTrapecio.AutoSize = true;
            this.lblResultadoTrapecio.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTrapecio.Location = new System.Drawing.Point(191, 327);
            this.lblResultadoTrapecio.Name = "lblResultadoTrapecio";
            this.lblResultadoTrapecio.Size = new System.Drawing.Size(28, 22);
            this.lblResultadoTrapecio.TabIndex = 22;
            this.lblResultadoTrapecio.Text = "...";
            // 
            // btnCalculaTrapecio
            // 
            this.btnCalculaTrapecio.BackColor = System.Drawing.Color.Blue;
            this.btnCalculaTrapecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaTrapecio.ForeColor = System.Drawing.Color.White;
            this.btnCalculaTrapecio.Location = new System.Drawing.Point(60, 278);
            this.btnCalculaTrapecio.Name = "btnCalculaTrapecio";
            this.btnCalculaTrapecio.Size = new System.Drawing.Size(218, 32);
            this.btnCalculaTrapecio.TabIndex = 21;
            this.btnCalculaTrapecio.Text = "Calcular";
            this.btnCalculaTrapecio.UseVisualStyleBackColor = false;
            this.btnCalculaTrapecio.Click += new System.EventHandler(this.btnCalculaTrapecio_Click);
            // 
            // numBaseMayorTrapecio
            // 
            this.numBaseMayorTrapecio.DecimalPlaces = 3;
            this.numBaseMayorTrapecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBaseMayorTrapecio.Location = new System.Drawing.Point(184, 123);
            this.numBaseMayorTrapecio.Name = "numBaseMayorTrapecio";
            this.numBaseMayorTrapecio.Size = new System.Drawing.Size(120, 29);
            this.numBaseMayorTrapecio.TabIndex = 20;
            // 
            // lblBaseMenorTrapecio
            // 
            this.lblBaseMenorTrapecio.AutoSize = true;
            this.lblBaseMenorTrapecio.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMenorTrapecio.Location = new System.Drawing.Point(56, 169);
            this.lblBaseMenorTrapecio.Name = "lblBaseMenorTrapecio";
            this.lblBaseMenorTrapecio.Size = new System.Drawing.Size(110, 22);
            this.lblBaseMenorTrapecio.TabIndex = 29;
            this.lblBaseMenorTrapecio.Text = "Base Menor:";
            // 
            // numBaseMenorTrapecio
            // 
            this.numBaseMenorTrapecio.DecimalPlaces = 3;
            this.numBaseMenorTrapecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBaseMenorTrapecio.Location = new System.Drawing.Point(184, 169);
            this.numBaseMenorTrapecio.Name = "numBaseMenorTrapecio";
            this.numBaseMenorTrapecio.Size = new System.Drawing.Size(120, 29);
            this.numBaseMenorTrapecio.TabIndex = 28;
            // 
            // lblLadoTrapecio
            // 
            this.lblLadoTrapecio.AutoSize = true;
            this.lblLadoTrapecio.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoTrapecio.Location = new System.Drawing.Point(56, 222);
            this.lblLadoTrapecio.Name = "lblLadoTrapecio";
            this.lblLadoTrapecio.Size = new System.Drawing.Size(54, 22);
            this.lblLadoTrapecio.TabIndex = 31;
            this.lblLadoTrapecio.Text = "Lado:";
            // 
            // numLadoTrapecio
            // 
            this.numLadoTrapecio.DecimalPlaces = 3;
            this.numLadoTrapecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLadoTrapecio.Location = new System.Drawing.Point(183, 219);
            this.numLadoTrapecio.Name = "numLadoTrapecio";
            this.numLadoTrapecio.Size = new System.Drawing.Size(120, 29);
            this.numLadoTrapecio.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Proyecto_1.Properties.Resources.Trapecio;
            this.pictureBox1.Location = new System.Drawing.Point(334, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Trapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(536, 407);
            this.Controls.Add(this.lblLadoTrapecio);
            this.Controls.Add(this.numLadoTrapecio);
            this.Controls.Add(this.lblBaseMenorTrapecio);
            this.Controls.Add(this.numBaseMenorTrapecio);
            this.Controls.Add(this.btnRegresarTrapecio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoTr);
            this.Controls.Add(this.lblBaseMayorTrapecio);
            this.Controls.Add(this.lblResultadoTrapecio);
            this.Controls.Add(this.btnCalculaTrapecio);
            this.Controls.Add(this.numBaseMayorTrapecio);
            this.Name = "Trapecio";
            this.Text = "Trapecio";
            ((System.ComponentModel.ISupportInitialize)(this.numBaseMayorTrapecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseMenorTrapecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLadoTrapecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresarTrapecio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoTr;
        private System.Windows.Forms.Label lblBaseMayorTrapecio;
        private System.Windows.Forms.Label lblResultadoTrapecio;
        private System.Windows.Forms.Button btnCalculaTrapecio;
        private System.Windows.Forms.NumericUpDown numBaseMayorTrapecio;
        private System.Windows.Forms.Label lblBaseMenorTrapecio;
        private System.Windows.Forms.NumericUpDown numBaseMenorTrapecio;
        private System.Windows.Forms.Label lblLadoTrapecio;
        private System.Windows.Forms.NumericUpDown numLadoTrapecio;
    }
}