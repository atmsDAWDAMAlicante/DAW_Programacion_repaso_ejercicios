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
                // Comprobado que los valores introducidos por los TextBox son números
                // se envían por parámetro a la función IdentificarMenor cuyo objeto es identificar cual de los dos es el 
                // menor y así reenviarlos a la función Calcular en el orden adecuado
                IdentificarMenor(numero1, numero2);
            }

            else
            {
                lblResultado.Text = "Introduce números.";
            }

        }

        public void IdentificarMenor(int numero1, int numero2)
        {
            int MCD;
            // Esta función identifica cuál de dos los números es el menor y los envía a la función Calcular 
            // en el siguiente orden Calcular(número mayor, número menor)
            if (numero1 > numero2)
            {   
                MCD = Calcular(numero1, numero2);
			} 
            else
            {
				MCD = Calcular(numero2, numero1);
			}
			lblResultado.Text = $"{MCD}";
		}

        public int Calcular(int numMayor, int numMenor)
        {
            int MCD = 1; // Si no hay otro número mayor, el máximo común divisor será 1
            // El bucle es decreciente, como el número a buscar ha de ser el "común", 
            // comienza el bucle desde el número menor y decrece hasta alcanzar el valor 1
            for (int i = numMenor; i > 0; i--)
			{ // Si encuentra el máximo común divisor, representado por la variable de control i (que decrece), lo devuelve, incluyendo el 1
				if ((numMayor % i == 0) && (numMenor % i == 0))
                {
                    return i;
                }
            }
            // En cualquier otro caso devolvería 1, pero este return está más bien para que Visual Studio permita compilar
            return MCD;
        }


    }
}
