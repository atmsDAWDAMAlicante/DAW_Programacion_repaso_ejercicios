using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_08_
{
    public partial class Prog_Tema_4_Ej_08 : Form
    {
        public Prog_Tema_4_Ej_08()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            // El label imprimirá por pantalla el resultado de la función ValidarCampos() que, devuelve un string
            lblResultado.Text = ValidarCampos();
		}


        public string ValidarCampos()
        {
            bool num1esnum = double.TryParse(txtNum1.Text, out double num1);
            bool num2esnum = double.TryParse(txtNum2.Text, out double num2);
            bool num3esnum = double.TryParse(txtNum3.Text, out double num3);

            if (num1esnum && num2esnum && num3esnum)
            {
				if ((num1 >= 0 && num1 < 11) && (num2 >= 0 && num2 < 11) && (num3 >= 0 && num3 < 11))
					{
					// Si los tres números introducidos son números válidos se envían a la función CalcularLaMedia
                    // que devolverá la media calculada y, una vez recibidos, se devuelven al evento click del botón
                    // que lo imprime por pantalla
					return CalcularLaMedia(num1, num2, num3);
					}
				else
					{
					return "Introduce un valor\nentre 0 y 10";
					}
            }
            else 
            {
                return "Introduce números.";
            }
        }


        public string CalcularLaMedia(double num1, double num2, double num3)
        {
            double media = (( num1 + num2 + num3 ) / 3 );
            return $"{media:F2}"; // :F2 formatea el double media con dos decimales
        }
        
    }

}
