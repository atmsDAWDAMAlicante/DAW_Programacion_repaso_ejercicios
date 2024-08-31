using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_21
	{
	public partial class Prog_Tema_3_Ej_21 : Form
		{
		public Prog_Tema_3_Ej_21()
			{
			InitializeComponent();
			}

		private void btnMostrar_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";
			bool numEsNum = int.TryParse(txtNumero.Text, out int numero);

			// El programa está pensado con dos bucles for, uno anidado dentro del otro
			// La variable numero, que recoge el valor introducido en el TextBox
			// será la que debe estar comprendida entre 1 y 15 y determinará el número de repeticiones del primer bucle for
			// El segundo bucle for (con una variable 'j' de control) confeccionará el string que se imprime por línea

			if (numEsNum)
				{
				if ((numero > 0) && (numero < 16))
					{
					for (int i = 0; i < numero; i++)
						{
						for (int j = 1; j < 11; j++)
							{
							lblResultado.Text += $"{j}-";
							}
						lblResultado.Text += "\n";
						}
					}
				else
					{
					lblResultado.Text = "Introduce un número del 1 al 15";
					}
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}

			}
		}
	}
