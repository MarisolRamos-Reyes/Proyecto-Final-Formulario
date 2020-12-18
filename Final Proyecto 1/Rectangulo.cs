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
    public partial class Rectangulo : Form
    {
        public Rectangulo()
        {
            InitializeComponent();
        }

        private void btnCalculaRectangulo_Click(object sender, EventArgs e)
        {
            CalcularPerimetros l = new CalcularPerimetros();
            decimal resultado = l.RectanguloPerimetro(numAlturaRectangulo.Value, numBaseRectangulo.Value);
            lblResultadoRectangulo.Text = resultado + "";
        }

        private void btnRegresarRectangulo_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPerimetros();
            formulario.Show();
            this.Close();
        }
    }
}
