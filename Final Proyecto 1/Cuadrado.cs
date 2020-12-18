using System;
using System.Windows.Forms;

namespace Final_Proyecto_1
{
    public partial class Cuadrado : Form
    {
        public Cuadrado()
        {
            InitializeComponent();
        }

        private void btnCalculaCuadrado_Click(object sender, EventArgs e)
        {

            CalcularPerimetros l = new CalcularPerimetros();
            decimal resultado = l.CuadradoPerimetro(numBaseCuadrado.Value);
            lblResultadoCuadrado.Text = resultado + "";
        }

        private void btnRegresarCuadrado_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPerimetros();
            formulario.Show();
            this.Close();
        }
    }
}
