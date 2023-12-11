using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_06
{
    public partial class Prog_Tema_4_Ej_06 : Form
    {
        public Prog_Tema_4_Ej_06()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            // Comprobación que se introducen números en los textBox

            bool num1esnum = int.TryParse(txtNumero1.Text, out int numero1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int numero2);

            if (num1esnum && num2esnum)
            {
                int resultadoDivision, resultadoResto;

                Calcular(numero1, numero2, out resultadoDivision, out resultadoResto);

                lblResultadoDivision.Text = resultadoDivision.ToString();
                lblResto.Text = resultadoResto.ToString();

            }
            else
            {
                lblResultadoDivision.Text = "Introduce números";
            }
        }

        public void Calcular(int numero1, int numero2, out int division, out int resto)
        {
            division = numero1 / numero2;
            resto = numero1 % numero2;
        }


    }
}
