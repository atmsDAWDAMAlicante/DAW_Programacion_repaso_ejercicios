using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_02
{
    public partial class Prog_Tema_4_Ej_02 : Form
    {
        public Prog_Tema_4_Ej_02()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            Comprobar();
        }

        public void Comprobar()
        {
            bool numero1num = double.TryParse(txtNumero1.Text, out double numero1);
            bool numero2num = double.TryParse(txtNumero2.Text, out double numero2);

            if (numero1num && numero2num)
            {
                EsDivisible(numero1, numero2);
            } else
            {
                lblResultado.Text = "Introduce números";
            }
        }

        public void EsDivisible(double numero1, double numero2)
        {
            double resto = numero1 % numero2;
            string negacion;
            if (resto == 0)
            {
                negacion = "";
            } else
            {
                negacion = " no";
            }


            lblResultado.Text = $"{numero1}{negacion} es divisible \npor {numero2}";
        }
    }
}
