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
    public partial class Hexagono : Form
    {
        public Hexagono()
        {
            InitializeComponent();
        }

        private void btnCalculaHexagono_Click(object sender, EventArgs e)
        {

            CalcularPerimetros l = new CalcularPerimetros();
            decimal resultado = l.HexagonoPerimetro(numLadoHexagono.Value);
            lblResultadoHexagono.Text = resultado + "";
        }

        private void btnRegresarHexagono_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPerimetros();
            formulario.Show();
            this.Close();
        }

    }
}
