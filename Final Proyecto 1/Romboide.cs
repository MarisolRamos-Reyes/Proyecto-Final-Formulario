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
    public partial class Romboide : Form
    {
        public Romboide()
        {
            InitializeComponent();
        }

        private void btnCalculaRombide_Click(object sender, EventArgs e)
        {
            CalcularPerimetros l = new CalcularPerimetros();
            decimal resultado = l.RomboidePerimetro(numAlturaRomboide.Value, numBaseRomboide.Value);
            lblResultadoRomboide.Text = resultado + "";
        }

        private void btnRegresarRomboide_Click(object sender, EventArgs e)
        {
            Form formulario = new MenuPerimetros();
            formulario.Show();
            this.Close();
        }
    }
}
