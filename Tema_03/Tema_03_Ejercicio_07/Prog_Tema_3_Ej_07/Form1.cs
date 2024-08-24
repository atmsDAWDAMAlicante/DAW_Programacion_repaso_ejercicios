using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_07
{
    public partial class Prog_Tema_3_Ej_07 : Form
    {
        public Prog_Tema_3_Ej_07()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
			// Con este método int.TryParse se evalúa si lo introducido es un número y lo convierte en un entero; si no lo es y devuelve un mensaje
			// No se utiliza try-catch
			bool numesnum = int.TryParse(txtNumero.Text, out int numero);

			// Bloque condicional if que evalúa si ha tenido éxito la conversión a entero de lo introducido en los TextBox
			if (numesnum)
            {
                // Dentro se evalúa el número introducido mediante un switch case
                switch (numero)
                {
                    case 0:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 1:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 2:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 3:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 4:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 5:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 6:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 7:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 8:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    case 9:
                        lblResultado.Text = $"Se ha apretado el {numero}";
                        break;

                    default:
                        lblResultado.Text = "¿Qué has apretado?";
                        break;

                }

                // Finaliazada la evaluación se deja vacío el TextBox y se le devuelve el foco con el método Focus()
                txtNumero.Text = "";
                txtNumero.Focus();
            } 
            else
            {
                lblResultado.Text = "Introduce números";
            }
        }
    }
}
