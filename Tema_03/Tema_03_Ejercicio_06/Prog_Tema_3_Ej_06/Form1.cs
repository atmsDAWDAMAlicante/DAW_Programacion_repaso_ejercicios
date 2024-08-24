using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_06
{
    public partial class Prog_Tema_3_Ej_06 : Form
    {
        public Prog_Tema_3_Ej_06()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
			// Con este método se evalúa si lo introducido es un número y lo convierte en un entero; si no lo es y devuelve un mensaje
			// No se utiliza try-catch
			bool notaesnum = double.TryParse(txtNota.Text, out double nota);

			// Bloque condicional if que evalúa si ha tenido éxito la conversión a entero de lo introducido en los TextBox
			if (notaesnum)
            {

				// Bloque condicional if para evaluar la nota introducida y devolver la calificación que le corresponde
				if (nota >= 0 && nota < 3)
                {
                    lblResultado.Text = "Muy deficiente";
                }
                else if (nota >= 3 && nota < 5)
                {
                    lblResultado.Text = "Insuficiente";
                }
                else if (nota >= 5 && nota < 6)
                {
                    lblResultado.Text = "Suficiente";
                }
                else if (nota >= 6 && nota < 7)
                {
                    lblResultado.Text = "Bien";
                }
                else if (nota >= 7 && nota < 9)
                {
                    lblResultado.Text = "Notable";
                }
                else if (nota >= 9 && nota <= 10)
                {
                    lblResultado.Text = "Sobresaliente";
                }
                else
                {
                    lblResultado.Text = "Introduce un número\nentre 0 y 10";
                }


            } else
            {
                lblResultado.Text = "Inroduce números";
            }
        }
    }
}
