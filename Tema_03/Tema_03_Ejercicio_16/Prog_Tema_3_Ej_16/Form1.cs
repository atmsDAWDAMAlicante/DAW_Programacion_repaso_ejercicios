using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_16
	{
	public partial class Prog_Tema_3_Ej_16 : Form
		{
		public int sumaTotal = 0;
		public Prog_Tema_3_Ej_16()
			{
			InitializeComponent();
			}

		private void btnSumar_Click(object sender, EventArgs e)
			{
			// Aunque el enunciado original hace referencia a realizar un programa similar al ejercicio anterior, con InputBox y 
			// un bucle Do...While, he preferido realizarlo de este modo para probar la declaración e inicialización de la variable
			// 'sumaTotal' en la línea 15, al comienzo de la clase. Se trata de una variable pública, por lo tanto 
			// puede ser invocada entro del evento click del botón btnSumar

			bool numEsNum = int.TryParse(txtNumeros.Text, out int numero);

			if (numEsNum)
				{
				// Este bloque condicional evalúa si el número introducido está dentro del rango permitido y, si así es
				// lo muestra por pantalla y lo suma a la variable global 'sumaTotal'
				// Si se introduce una letra o un número fuera de rango, la variable 'sumaTotal' mantiene su valor, por lo que 
				// si, a continuación, se introduce un número dentro del rango, la variable 'sumaTotal' sigue mostrando la suma de todos
				// los números introducidos
				if ((numero >= 0) && (numero <= 9))
					{
					sumaTotal += numero;
					lblIntroducidos.Text = $"Número introducido: {numero}";
					lblResultado.Text = $"{sumaTotal}";
					}
				else
					{
					lblResultado.Text = "Número fuera de rango";
					lblIntroducidos.Text = "Introduce un número entre el 0 y el 9.";
					}
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				lblIntroducidos.Text = "Formato erróneo";
				}
			}
		}
	}
