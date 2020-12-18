using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proyecto_1
{
    public partial class MenuPerimetros : Form
    {
        public MenuPerimetros()
        {
            InitializeComponent();
        }

        private void btnFormCuadrado_Click(object sender, EventArgs e)
        {
            Form formulario = new Cuadrado();
            formulario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }

        private void btnFormRectangulo_Click(object sender, EventArgs e)
        {
            Form formulario = new Rectangulo();
            formulario.Show();
            this.Close();
        }

        private void btnFormHexagono_Click(object sender, EventArgs e)
        {
            Form formulario = new Hexagono();
            formulario.Show();
            this.Close();
        }

        private void btnFormPentagono_Click(object sender, EventArgs e)
        {
            
            Form formulario = new Pentagono();
            formulario.Show();
            this.Close();
        }

        private void btnFormTrapecio_Click(object sender, EventArgs e)
        {
            Form formulario = new Trapecio();
            formulario.Show();
            this.Close();

        }

        private void btnFormRomboide_Click(object sender, EventArgs e)
        {
            Form formulario = new Romboide();
            formulario.Show();
            this.Close();

        }

        private void btnFormCirculo_Click(object sender, EventArgs e)
        {
            Form formulario = new Circulo();
            formulario.Show();
            this.Close();
        }

        private void btnFormTriangulo_Click(object sender, EventArgs e)
        {
            Form formulario = new Triangulo();
            formulario.Show();
            this.Close();
        }
    }
}
