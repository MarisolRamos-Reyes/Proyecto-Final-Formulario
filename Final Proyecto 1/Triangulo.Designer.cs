namespace Final_Proyecto_1
{
    partial class Triangulo
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
            this.lblLado2 = new System.Windows.Forms.Label();
            this.numLado2 = new System.Windows.Forms.NumericUpDown();
            this.btnRegresarTriangulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoT = new System.Windows.Forms.Label();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lblResultadoTriangulo = new System.Windows.Forms.Label();
            this.btnCalculaTriangulo = new System.Windows.Forms.Button();
            this.numLado1 = new System.Windows.Forms.NumericUpDown();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.numLado3 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado2.Location = new System.Drawing.Point(30, 159);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(71, 22);
            this.lblLado2.TabIndex = 29;
            this.lblLado2.Text = "Lado 2 ";
            // 
            // numLado2
            // 
            this.numLado2.DecimalPlaces = 3;
            this.numLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLado2.Location = new System.Drawing.Point(107, 159);
            this.numLado2.Name = "numLado2";
            this.numLado2.Size = new System.Drawing.Size(120, 29);
            this.numLado2.TabIndex = 28;
            // 
            // btnRegresarTriangulo
            // 
            this.btnRegresarTriangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegresarTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarTriangulo.Location = new System.Drawing.Point(273, 355);
            this.btnRegresarTriangulo.Name = "btnRegresarTriangulo";
            this.btnRegresarTriangulo.Size = new System.Drawing.Size(155, 32);
            this.btnRegresarTriangulo.TabIndex = 27;
            this.btnRegresarTriangulo.Text = "Regresar";
            this.btnRegresarTriangulo.UseVisualStyleBackColor = false;
            this.btnRegresarTriangulo.Click += new System.EventHandler(this.btnRegresarTriangulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(87, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "Triangulo";
            // 
            // lblResultadoT
            // 
            this.lblResultadoT.AutoSize = true;
            this.lblResultadoT.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoT.Location = new System.Drawing.Point(30, 327);
            this.lblResultadoT.Name = "lblResultadoT";
            this.lblResultadoT.Size = new System.Drawing.Size(92, 22);
            this.lblResultadoT.TabIndex = 24;
            this.lblResultadoT.Text = "Resultado:";
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado1.Location = new System.Drawing.Point(30, 116);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(71, 22);
            this.lblLado1.TabIndex = 23;
            this.lblLado1.Text = "Lado 1:";
            // 
            // lblResultadoTriangulo
            // 
            this.lblResultadoTriangulo.AutoSize = true;
            this.lblResultadoTriangulo.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTriangulo.Location = new System.Drawing.Point(165, 327);
            this.lblResultadoTriangulo.Name = "lblResultadoTriangulo";
            this.lblResultadoTriangulo.Size = new System.Drawing.Size(28, 22);
            this.lblResultadoTriangulo.TabIndex = 22;
            this.lblResultadoTriangulo.Text = "...";
            // 
            // btnCalculaTriangulo
            // 
            this.btnCalculaTriangulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalculaTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaTriangulo.Location = new System.Drawing.Point(34, 278);
            this.btnCalculaTriangulo.Name = "btnCalculaTriangulo";
            this.btnCalculaTriangulo.Size = new System.Drawing.Size(218, 32);
            this.btnCalculaTriangulo.TabIndex = 21;
            this.btnCalculaTriangulo.Text = "Calcular";
            this.btnCalculaTriangulo.UseVisualStyleBackColor = false;
            this.btnCalculaTriangulo.Click += new System.EventHandler(this.btnCalculaTriangulo_Click);
            // 
            // numLado1
            // 
            this.numLado1.DecimalPlaces = 3;
            this.numLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLado1.Location = new System.Drawing.Point(107, 109);
            this.numLado1.Name = "numLado1";
            this.numLado1.Size = new System.Drawing.Size(120, 29);
            this.numLado1.TabIndex = 20;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado3.Location = new System.Drawing.Point(30, 212);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(71, 22);
            this.lblLado3.TabIndex = 31;
            this.lblLado3.Text = "Lado 3:";
            // 
            // numLado3
            // 
            this.numLado3.DecimalPlaces = 3;
            this.numLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLado3.Location = new System.Drawing.Point(107, 212);
            this.numLado3.Name = "numLado3";
            this.numLado3.Size = new System.Drawing.Size(120, 29);
            this.numLado3.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Proyecto_1.Properties.Resources.Triangulo;
            this.pictureBox1.Location = new System.Drawing.Point(285, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(460, 403);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.numLado3);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.numLado2);
            this.Controls.Add(this.btnRegresarTriangulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoT);
            this.Controls.Add(this.lblLado1);
            this.Controls.Add(this.lblResultadoTriangulo);
            this.Controls.Add(this.btnCalculaTriangulo);
            this.Controls.Add(this.numLado1);
            this.Name = "Triangulo";
            this.Text = "Triangulo";
            ((System.ComponentModel.ISupportInitialize)(this.numLado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.NumericUpDown numLado2;
        private System.Windows.Forms.Button btnRegresarTriangulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoT;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.Label lblResultadoTriangulo;
        private System.Windows.Forms.Button btnCalculaTriangulo;
        private System.Windows.Forms.NumericUpDown numLado1;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.NumericUpDown numLado3;
    }
}