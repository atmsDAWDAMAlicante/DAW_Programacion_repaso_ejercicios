using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_05
{
    public partial class Prog_Tema_4_Ej_05 : Form
    {
        public Prog_Tema_4_Ej_05()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            bool numero1num = int.TryParse(txtNumero1.Text, out int numero1);
            bool numero2num = int.TryParse(txtNumero2.Text, out int numero2);
            if (numero1num && numero2num)
            {
                Operacion(numero1, numero2);
            }
            else
            {
                lblResultado.Text = "Introduce números";
            }
        }

        public void Operacion(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                lblResultado.Text = $"{numero1}";
            } else if (numero1 < numero2)
            {
                lblResultado.Text = $"{numero2}";
            } else if (numero1 == numero2)
            {
                lblResultado.Text = "Son iguales";
            } else
            {
                lblResultado.Text = "Algo va mal";
            }
        }
    }
}
