using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_17
	{
	public partial class Prog_Tema_3_Ej_17 : Form
		{
		public Prog_Tema_3_Ej_17()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";
			// Declaro e inicializo un par de variables:
			// un entero 'cadaVuelta' que se incrementará dentro del bucle para determinar en qué vuelta se está y si es divisible por el número
			// de vuelta que cambiará el contenido de la siguiente variable string 'saltoLinea' para que el resultado muestre n números por línea
			// La variable 'saltoLinea' valdrá \n cuando haya que introducirse un salto de línea, y una cadena vacía en el resto de los casos

			int cadaVuelta = 9; // Cada vuelta tiene que tener un valor superior al número a partir del cual se añadirá un salto de línea
			// Si no se hace así, en la primera línea aparecerán menos números de los indicados en if (cadaVuelta % 8 == 0)

			string saltoLinea = $"\n";

			// Inicializo el bucle for con el valor 1 hasta 101 para que recorra las 100 posiciones comenzando por el 1
			for (int i = 1; i < 101; i++) 
				{
				if (cadaVuelta % 8 == 0)
					{
						saltoLinea = $"\n";
					}
                else
					{
						saltoLinea = $"";
					}
				// En este bloque condicional se evalúa e imprime el número de que se trate si es múltiplo de 3
				// junto al número se añade la variable 'saltoLinea' que tomará el valor que corresponda a 'cadaVuelta'
				if (i % 3 == 0)
					{
					lblResultado.Text += $"{i}, {saltoLinea}";
					cadaVuelta++;
					}

				}
			}
		}
	}
