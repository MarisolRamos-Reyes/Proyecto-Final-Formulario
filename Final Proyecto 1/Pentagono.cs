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
    public partial class Pentagono : Form
    {
        public Pentagono()
        {
            InitializeComponent();
        }

        private void btnCalculaPentagono_Click(object sender, EventArgs e)
        {
            CalcularPerimetros l = new CalcularPerimetros();
            decimal resultado = l.PentagonoPerimetro(numLadoPentagono.Value);
            lblResultadoPentagono.Text = resultado + "";
        }

        private void btnRegresarPentagono_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPerimetros();
            formulario.Show();
            this.Close();
        }
    }
}
