using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_29
	{
	public partial class Prog_Tema_3_Ej_29 : Form
		{
		public Prog_Tema_3_Ej_29()
			{
			InitializeComponent();
			}

		private void btnMostrar_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			bool numEsNum = double.TryParse(txtNumero.Text, out double numero);


			// La operación a realizar es la siguiente:
			// 1 - 1/2 + 1/3 - 1/4........(+ -) 1/n

			// Conforme el enunciado del programa, la primera operación se realiza sobre el número 1
			// por tanto, la variable 'resultado', que acumulará el resultado, se declara e inicializa con valor 1 "1 - 1/2"
			//  Esta variable 'resultado' será de tipo double para que se muestren los decimales resultantes.
			double resultado = 1;

			// Las operaciones alternan sumas y restas por lo que es necesario almacenar el signo de la operación para
			// que el programa sume o reste en función de ese valor. La variable 'signo' se encarga de ello,  
			// siendo inicializada con el valor false, que representará la resta, para realizar "1 - 1/2" en la primera vuelta
			bool signo = false;

			// Es necesario tener una variable que se incremente cada vuelta. Esta variable 'contador' será de tipo double para
			// que el resultado muestre los decimales de cada operación. Por tanto queda descartado el bucle for y el uso
			// de la variable de control del bucle for porque tiene que ser forzosamente un entero.
			// Además, con el bucle escogido, Do...While, se ejecuta el código, al menos, la primera vez.
			double contador = 1;

			if (numEsNum)
				{
				if (numero > 0)
					{
					do
						{
						// Iniciado el bucle, un bloque condicional evalúa la variable signo que determinará si se suma o resta
						// Dentro de cada una de las alternativas, además de la operación que se trate, se incrementa la variable 'contador' 
						// y se cambia el valor de la variable 'signo' para que, en la siguiente vuelta, se realize la otra operación.
						if (signo == true)
							{
							contador++;
							resultado += (1 / contador);
							signo = !(signo);
							}
						else
							{
							contador++;
							resultado -= (1 / contador);
							signo = !(signo);
							}

						} while (contador < numero);
					
					lblResultado.Text = $"El resultado es {resultado}";
					}
				else
					{
					lblResultado.Text = "Introduce un número mayor que 0";
					}

				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}
			}
		}
	}