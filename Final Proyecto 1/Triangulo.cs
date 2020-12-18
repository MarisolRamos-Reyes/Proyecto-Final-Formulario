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
    public partial class Triangulo : Form
    {
        public Triangulo()
        {
            InitializeComponent();
        }

        private void btnCalculaTriangulo_Click(object sender, EventArgs e)
        {
            CalcularPerimetros l = new CalcularPerimetros();
            decimal resultado = l.TrianguloPerimetro(numLado1.Value, numLado2.Value, numLado3.Value );
            lblResultadoTriangulo.Text = resultado + "";
        }

        private void btnRegresarTriangulo_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPerimetros();
            formulario.Show();
            this.Close();
        }
    }
}
