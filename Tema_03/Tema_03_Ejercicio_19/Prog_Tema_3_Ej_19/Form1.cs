using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_19
	{
	public partial class Prog_Tema_3_Ej_19 : Form
		{
		public Prog_Tema_3_Ej_19()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{

			// La variable 'numero' recoge la conversión a entero del número introducido por el TextBox
			// esta variable determina el inicio del bucle for, que será decreciente

			bool numEsNum = int.TryParse(txtNumero.Text, out int numero);

			// A la variable resultado se le multiplicarán las posiciones de 'i' dentro del bucle, acumulando la operación
			// al tratarse de multiplicaciones no puede tener el valor 0 porque, en ese caso, cualquier número multiplicado por 0 es 0
			int resultado = 1;

			if (numEsNum)
				{
				// La variable 'i' toma el valor de 'numero'; el bucle se repite mientras i es mayor que 0 y, cada vuelta, se decrementa
				for (int i = numero; i > 0; i--)
					{
					resultado *= i; // aquí se acumulan las multiplicaciones del factorial
					}

				lblResultado.Text = $"{resultado}"; // Si 'numero' es mayor que 16, la operación devuelve un resultado inesperado 
				// ya que se desborda al ser un valor mayor al soportado por un entero. Una alternativa es declarar la 
				// variable resultado como un long: long resultado = 1;
				}

			else
				{
				lblResultado.Text = "Introduce números";
				}

			}
		}
	}
