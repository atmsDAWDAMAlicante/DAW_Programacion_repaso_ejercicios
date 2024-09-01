using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_27
	{
	public partial class Prog_Tema_3_Ej_27 : Form
		{
		public Prog_Tema_3_Ej_27()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			const int TOPE = 300;
			lblResultado.Text = "";

			bool numEsNum = int.TryParse(txtNumero.Text, out int numero);
			// Este primer bloque if evalúa que el carácter introducido en el TextBox sea un número
			if (numEsNum)
				{
				// Este segundo bloque if evalúa que el número introducido en el TextBox sea inferior al valor de la constante TOPE
				if ((numero > 2) && (numero < TOPE))
					{
					// Si el número introducido es un entero, superior a 2 e inferior al valor de la constante TOPE, se ejecuta el contenido 
					// de este bloque if que calcula si el número introducido es primo.
					// 1º Para ello se declara una variable entero 'restoCero' que hará de contador de las veces en que la división 
					// del número introducido por todos los demás números, inferiores a él, da 0. 
					int restoCero = 0;
					//2º Dentro del bucle for se efectúan las operaciones módulo de la variable 'numero' % 'i'
					// Si el resultado de dicha operación es 0, se incrementa la variable 'restoCero' que fue inicializada a 0
					for (int i = 1; i <= numero; i++)
						{
						if (numero%i == 0)
							{
							restoCero++;
							}
						}
					// 3º Se evalúa el valor de la variable 'restoCero'
					// Si tiene un valor igual a 2, el número es primo, porque se cumple la condición que es divisible sólo por 1 y por él mismo
					// En caso contrario no lo es
					// Esta condición se evalúa fuera del bucle for

					if (restoCero <=2)
						{
						lblResultado.Text = $"El {numero} SÍ es primo.";
						}
					else
						{
						lblResultado.Text = $"El {numero} NO es primo.";
						}
					}
				else
					{
					lblResultado.Text = $"Introduce un número mayor\nque 2 e inferior a {TOPE}";
					}
				}
			
			else
				{
				lblResultado.Text = "Introduce números.";
				}

			}
		}
	}
