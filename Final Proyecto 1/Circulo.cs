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
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void btnCalculaCirculo_Click(object sender, EventArgs e)
        {
            CalcularPerimetros l = new CalcularPerimetros();
            decimal resultado = l.CirculoPerimetro(numRadioCirculo.Value);
            lblResultadoCirculo.Text = resultado + "";
        }

        private void btnRegresarCirculo_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPerimetros();
            formulario.Show();
            this.Close();
        }
    }
}
