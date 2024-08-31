using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_18
	{
	public partial class Prog_Tema_3_Ej_18 : Form
		{
		public Prog_Tema_3_Ej_18()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			// Primero se declara e inicializan dos variables enteros
			// La variable 'contador' que se incrementará cada vuelta del bucle Do...While será el número que se sumará si es par
			// La variable 'resultado' irá acumulando las sumas

			int contador = 0;
			int resultado = 0;

			do
				{ // Al menos una vez (cuando 'contador' vale 0) se evalúa si contador es par
				if (contador % 2 == 0)
					{
					// Si contador es par, se suma a la variable 'resultado' cuyo valor inicial es 0
					resultado += contador; 
					}
				// Efecutada la evaluación, fuera de la misma, se incrementa 'contador'
				contador++; 

				} while (contador < 51); // El bucle se repetirá hasta que 'contador' sea mayor que 50

			lblResultado.Text = $"{resultado}";
			}
		}
	}
