using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prog_Tema_3_Ej_15
	{
	public partial class Prog_Tema_3_Ej_15 : Form
		{
		public Prog_Tema_3_Ej_15()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			// Pasos para activar el InputBox 
			// 1º Ir al explorador de soluciones y hacer click con el botón derecho sobre Referencias y escoger Agregar referencias
			// 2º En la siguiente ventana activar el check de Microsoft.VisualBasic y aceptar
			// 3º Comprobar en el código del Form que está la directiva using Microsoft.VisualBasic; (si no, ponerla arriba)
			// InputBox es un método de Interaction: Interaction.InputBox("Mensaje a mostrar en la venana");
			// Lo que se introduzca a través de un InputBox se almacena en una variable string


			// Si se sale del pograma al capturar la excepción del bloque try-catch y se vuelve a hacer click en el botón
			// se actualizará el valor de estas variables a 0

			int numero = 0;
			int mayor = 0;
			int menor = 0;


			try { 
				do // Se utiliza un bucle do... while para que, al menos, se ejecute una vez el código
					{
					// Explicación del bloque if

					// Si 'numero' es mayor que 'mayor' se actualiza 'mayor' al valor actual de 'numero'
					// En la primera vuelta, mayor = 0 por lo que cualquier número es mayor que 0
					// a partir de la introducción de números mayores que 0 se va actualizando

					if (numero > mayor) 
							{ 
							mayor = numero; 
							}
						else // en caso contrario (lo que incluye que numero sea igual a) se acutaliza 'menor' al valor actual de 'numero'
							{
							menor = numero;
							}

						// La introducción del valor 'numero' se repite al final del bucle do...while
						// en este momento se actualiza el valor de 'numero'
						numero = int.Parse(Interaction.InputBox("Introduce un número"));

					// A continuación se evalúa si es menor que 0 para salir del bucle, mediante la condición del while

					} while (numero > 0); // El bucle se repetirá mientras el número introducido sea un número mayor que 0

					// Finalizado el bucle se imprimirá el resultado en los label

					lblElMayor.Text += $" {mayor}";
					lblElMenor.Text += $" {menor}";
			}

			catch (FormatException) 
				{
				MessageBox.Show("Introduce números");
				}
			}
		}
	}
