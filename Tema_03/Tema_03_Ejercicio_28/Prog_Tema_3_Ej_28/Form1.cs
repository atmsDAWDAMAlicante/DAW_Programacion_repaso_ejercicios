using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_28
	{
	public partial class Prog_Tema_3_Ej_28 : Form
		{
		public Prog_Tema_3_Ej_28()
			{
			InitializeComponent();
			}

		private void btnMostrar_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			// Se declara e inicializa una variable entera 'resultado' donde se almacenará el resultado
			int resultado = 0;

			// Los dos números de la multiplicación se almacenarán en las variables 'num1' y 'num2'
			bool numEsNum1 = int.TryParse(txtNumero1.Text, out int num1);
			bool numEsNum2 = int.TryParse(txtNumero2.Text, out int num2);



			// Es necesario recordar el signo de los números introducidos a efecto de mostrar el resultado. Para ello se declaran
			// dos variables booleanas 'num1Positivo' y 'num2Positivo' que almacenarán false si el respectivo número es negativo

			bool num1Positivo;
			bool num2Positivo;

			if (num1 < 0)
				num1Positivo = false;
			else
				num1Positivo = true;

			if (num2 < 0)
				num2Positivo = false;
			else
				num2Positivo = true;


			// Ahora hay que poner ambos números con signo positivo, en caso que sean negativos, para que realicen correctamente las sumas.
			// Además, el número almacenado en la variable 'num2' es el que hará las veces de multiplicador. Por tanto determinará 
			// el número de veces que ha de repetirse el bucle for para que se realicen las sumas sucesivas
			// En caso de ser un números negativos habrá que convertirlos en un números positivos, lo que se realiza multiplicándolo por -1
			// Las variables booleanas 'num1Positivo' y 'num2Positivo' conservan el signo original con que fueron introducidos en el TextBox
			if (num1Positivo == false)
				{
				num1 *= -1;
				}

			if (num2Positivo == false)
				{
				num2 *= -1;
				}

			if ((numEsNum1) && (numEsNum2))
				{
				// Bucle for en el que se realizarán las sumas sucesivas, almacenando el resultado positivo en la variable 'resultado'
				for (int i = 0; i < num2; i++)
					{
					resultado += num1;
					}

				// Finalizado el bucle for hay que darle a la variable 'resultado' el signo que le corresponde antes de imprimirla por pantalla
				// Si los números introducidos tenían distinto signo, el resultado deberá ser negativo, lo que se obtiene multiplicando
				// 'resultado' * -1
				if ( ((num1Positivo) && (num2Positivo)) || ((!num1Positivo) && (!num2Positivo)) )
					{
					lblResultado.Text = $"El resultado es {resultado}";
					}
				else
					{
					lblResultado.Text = $"El resultado es {resultado * -1}";
					}
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}

			}
		}
	}
