using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_14_
	{
	public partial class Prog_Tema_4_Ej_14 : Form
		{
		public Prog_Tema_4_Ej_14()
			{
			InitializeComponent();
			}

		private void btnSuCambio_Click(object sender, EventArgs e)
			{
			// Con la cantidad 18888 salen todos los billetes y monedas

			lblResultado.Text = "";
			int unidades;
			bool entradaEsNum = int.TryParse(txtCantidad.Text, out int cantidad);

			if ((entradaEsNum) && (cantidad > 0))
				{
				// Cada dos líneas se llaman a dos funciones. 
				// 'CalcularUnidades' devuelve el número de unidades del tipo que corresponde a la cantidad que se le pasa
				// y reduce el valor de la variable 'cantidad' que se le pasa por referencia

				// La variable 'ImprimirResultado' recibe la unidad y la cuantía de cada billete o moneda y va concatenando el resultado que imprime
				unidades = CalcularUnidades(ref cantidad, 10000);
				ImprimirResultado(unidades, 10000);
				unidades = CalcularUnidades(ref cantidad, 5000);
				ImprimirResultado(unidades, 5000);
				unidades = CalcularUnidades(ref cantidad, 2000);
				ImprimirResultado(unidades, 2000);
				unidades = CalcularUnidades(ref cantidad, 1000);
				ImprimirResultado(unidades, 1000);
				unidades = CalcularUnidades(ref cantidad, 500);
				ImprimirResultado(unidades, 500);
				unidades = CalcularUnidades(ref cantidad, 200);
				ImprimirResultado(unidades, 200);
				unidades = CalcularUnidades(ref cantidad, 100);
				ImprimirResultado(unidades, 100);
				unidades = CalcularUnidades(ref cantidad, 50);
				ImprimirResultado(unidades, 50);
				unidades = CalcularUnidades(ref cantidad, 25);
				ImprimirResultado(unidades, 25);
				unidades = CalcularUnidades(ref cantidad, 10);
				ImprimirResultado(unidades, 10);
				unidades = CalcularUnidades(ref cantidad, 5);
				ImprimirResultado(unidades, 5);
				unidades = CalcularUnidades(ref cantidad, 2);
				ImprimirResultado(unidades, 2);
				unidades = CalcularUnidades(ref cantidad, 1);
				ImprimirResultado(unidades, 1);
				}
			else
				{
				lblResultado.Text = "Introduzca números posiivos.";
				}
			}

		public int CalcularUnidades(ref int cantidad, int fraccion)
			{
			// Una variable recoge las unidades resultantes para cada cuantía que se pasa a la función
			int unidades = cantidad / fraccion;
			// A continuación se actualiza la variable 'cantidad' que se ha pasado por referencia
			cantidad -= (fraccion * unidades);
			// Finalmente se retorna las unidades resultantes
			return unidades;
			}
		public void ImprimirResultado(int unidades, int fraccion)
			{
				string tipo = "billete";
				string plural = "";

				// Sólo si hay unidades de una cuantía determinada, se imprimirá una línea para esa cuantía
				if (unidades != 0)
				{
					// Con este bloque condicional se imprime en plural o singular las palabras 'billete' o 'moneda'
					if (unidades > 1)
					{ 
						plural = "s";
					}
					else
					{ 
						plural = "";
					}

					// Con este bloque condicional se imprime la palabras 'billete' o 'moneda'
					if (fraccion >= 1000)
					{ 
						tipo = "billete";
					}
					else
					{ 
						tipo = "moneda";
					}
				// Aquí se van concatenando todas las cadenas, cada vez que se llama a la función y las unidades son > 0
				lblResultado.Text += $"{unidades} {tipo}{plural} de {fraccion} pesetas.\n";
				}
			}



		}
	}
