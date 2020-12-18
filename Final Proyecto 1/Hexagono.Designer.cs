namespace Final_Proyecto_1
{
    partial class Hexagono
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
            this.btnRegresarHexagono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultadoH = new System.Windows.Forms.Label();
            this.lblLadoHexagono = new System.Windows.Forms.Label();
            this.lblResultadoHexagono = new System.Windows.Forms.Label();
            this.btnCalculaHexagono = new System.Windows.Forms.Button();
            this.numLadoHexagono = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLadoHexagono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarHexagono
            // 
            this.btnRegresarHexagono.BackColor = System.Drawing.Color.Black;
            this.btnRegresarHexagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarHexagono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresarHexagono.Location = new System.Drawing.Point(236, 263);
            this.btnRegresarHexagono.Name = "btnRegresarHexagono";
            this.btnRegresarHexagono.Size = new System.Drawing.Size(155, 32);
            this.btnRegresarHexagono.TabIndex = 17;
            this.btnRegresarHexagono.Text = "Regresar";
            this.btnRegresarHexagono.UseVisualStyleBackColor = false;
            this.btnRegresarHexagono.Click += new System.EventHandler(this.btnRegresarHexagono_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("AR BLANCA", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(120, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hexagono";
            // 
            // lblResultadoH
            // 
            this.lblResultadoH.AutoSize = true;
            this.lblResultadoH.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoH.Location = new System.Drawing.Point(38, 233);
            this.lblResultadoH.Name = "lblResultadoH";
            this.lblResultadoH.Size = new System.Drawing.Size(92, 22);
            this.lblResultadoH.TabIndex = 14;
            this.lblResultadoH.Text = "Resultado:";
            // 
            // lblLadoHexagono
            // 
            this.lblLadoHexagono.AutoSize = true;
            this.lblLadoHexagono.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoHexagono.Location = new System.Drawing.Point(38, 129);
            this.lblLadoHexagono.Name = "lblLadoHexagono";
            this.lblLadoHexagono.Size = new System.Drawing.Size(54, 22);
            this.lblLadoHexagono.TabIndex = 13;
            this.lblLadoHexagono.Text = "Lado:";
            // 
            // lblResultadoHexagono
            // 
            this.lblResultadoHexagono.AutoSize = true;
            this.lblResultadoHexagono.Font = new System.Drawing.Font("NewsGoth Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoHexagono.Location = new System.Drawing.Point(177, 233);
            this.lblResultadoHexagono.Name = "lblResultadoHexagono";
            this.lblResultadoHexagono.Size = new System.Drawing.Size(28, 22);
            this.lblResultadoHexagono.TabIndex = 12;
            this.lblResultadoHexagono.Text = "...";
            // 
            // btnCalculaHexagono
            // 
            this.btnCalculaHexagono.BackColor = System.Drawing.Color.Black;
            this.btnCalculaHexagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaHexagono.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculaHexagono.Location = new System.Drawing.Point(42, 181);
            this.btnCalculaHexagono.Name = "btnCalculaHexagono";
            this.btnCalculaHexagono.Size = new System.Drawing.Size(218, 32);
            this.btnCalculaHexagono.TabIndex = 11;
            this.btnCalculaHexagono.Text = "Calcular";
            this.btnCalculaHexagono.UseVisualStyleBackColor = false;
            this.btnCalculaHexagono.Click += new System.EventHandler(this.btnCalculaHexagono_Click);
            // 
            // numLadoHexagono
            // 
            this.numLadoHexagono.DecimalPlaces = 3;
            this.numLadoHexagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLadoHexagono.Location = new System.Drawing.Point(115, 122);
            this.numLadoHexagono.Name = "numLadoHexagono";
            this.numLadoHexagono.Size = new System.Drawing.Size(120, 29);
            this.numLadoHexagono.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Proyecto_1.Properties.Resources.Hexagono;
            this.pictureBox1.Location = new System.Drawing.Point(284, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Hexagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(425, 316);
            this.Controls.Add(this.btnRegresarHexagono);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoH);
            this.Controls.Add(this.lblLadoHexagono);
            this.Controls.Add(this.lblResultadoHexagono);
            this.Controls.Add(this.btnCalculaHexagono);
            this.Controls.Add(this.numLadoHexagono);
            this.Name = "Hexagono";
            this.Text = "Hexagono";
            ((System.ComponentModel.ISupportInitialize)(this.numLadoHexagono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarHexagono;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultadoH;
        private System.Windows.Forms.Label lblLadoHexagono;
        private System.Windows.Forms.Label lblResultadoHexagono;
        private System.Windows.Forms.Button btnCalculaHexagono;
        private System.Windows.Forms.NumericUpDown numLadoHexagono;
    }
}