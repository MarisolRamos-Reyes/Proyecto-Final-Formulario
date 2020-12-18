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
    public partial class Trapecio : Form
    {
        public Trapecio()
        {
            InitializeComponent();
        }

        private void btnCalculaTrapecio_Click(object sender, EventArgs e)
        {
            CalcularPerimetros l = new CalcularPerimetros();
            decimal resultado = l.TrapecioPerimetro(numBaseMayorTrapecio.Value, numBaseMenorTrapecio.Value, numLadoTrapecio.Value);
            lblResultadoTrapecio.Text = resultado + "";
        }

        private void btnRegresarTrapecio_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPerimetros();
            formulario.Show();
            this.Close();

        }

    }
}
