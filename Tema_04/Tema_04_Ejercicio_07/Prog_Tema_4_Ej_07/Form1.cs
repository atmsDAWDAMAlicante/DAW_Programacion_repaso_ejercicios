using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_07_
{
    public partial class Prog_Tema_4_Ej_07 : Form
    {
        public Prog_Tema_4_Ej_07()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            bool num1esnum = int.TryParse(txtNumero1.Text, out int numero1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int numero2);

            if (num1esnum && num2esnum)
            {
                IdentificarMenor(numero1, numero2);
            }

            else
            {
                lblResultado.Text = "Introduce números";
            }

        }

        public void IdentificarMenor(int numero1, int numero2)
        {

            if (numero1 > numero2)
            {
                Calcular(numero1, numero2);
            } else
            {
                Calcular(numero2, numero1);
            }



        }

        public void Calcular(int numMayor, int numMenor)
        {
            int MCD = 0;
            for (int i = 1; i < numMenor; i++)
            {
                if ((numMayor % i == 0) && (numMenor % i == 0))
                {
                    MCD = i;
                } 
            }

            lblResultado.Text = $"El Máximo\nComún\nDivisor de\n{numMayor} y {numMenor} es {MCD}";
        }


    }
}
