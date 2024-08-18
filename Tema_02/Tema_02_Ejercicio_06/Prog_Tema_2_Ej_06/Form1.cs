using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_06
	{
	public partial class Prog_Tema_2_Ej_06 : Form
		{
		public Prog_Tema_2_Ej_06()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			try 
				{ 
				// Declaración, inicialización y conversión en enteros de las variables que recogen los valores de los TextBox
				int numero = int.Parse(txtNumero.Text);
				int divisor = int.Parse(txtDivisor.Text);

				// Declaración y operaciones de las dos variables que recogen los resultados de éstas
				int division = numero / divisor;
				int resto = numero % divisor;

				// Muestra de los resultados mediante un MessageBox
				MessageBox.Show("Resultados:\nDivisión = " + division.ToString() + "\nResto = " + resto.ToString());
				}

			catch (FormatException) // captura del error de la introducción de caracteres no numéricos
				{
				MessageBox.Show("Introduzca números.");
				}
			catch (DivideByZeroException) // captura del error de la división por cero
				{
				MessageBox.Show("Error: división por cero");
				}

			}
		}
	}
