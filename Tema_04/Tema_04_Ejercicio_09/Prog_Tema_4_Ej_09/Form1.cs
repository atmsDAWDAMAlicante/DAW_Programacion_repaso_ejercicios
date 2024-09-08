using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_09_
	{
	public partial class Prog_Tema_4_Ej_09 : Form
		{
		public Prog_Tema_4_Ej_09()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";
			bool baseEsNum = double.TryParse(txtBase.Text, out double basePotencia);
			bool exponenteEsNum = double.TryParse(txtExponente.Text, out double exponentePotencia);
			if ((baseEsNum) && (exponenteEsNum))
				{
				// La idea era que en la función para calcuar la potencia 'EjecutarPotencia()' se capturara la excepción con 'ArgumentOutOfRangeException'
				// pero Math.Pow no captura esa excepción, por eso nunca devuelve el return 0 del bloque catch

				double resultado = EjecutarPotencia(basePotencia, exponentePotencia);
				// En lugar de evaluar que resultado es un número mayor al indicado en la linea de abajo
				// if (resultado > 1.79769313486232e307) es mejor evaluar si es infinito
				// omitiendo el bloque try... catch en la función 'EjecutarPotencia()'
				if (double.IsInfinity(resultado))
					{
					lblResultado.Text = "Numero fuera de rango.";
					}
				else if (resultado != 0)
					{
					lblResultado.Text = $"{resultado}";
					}
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}
			}

		public double EjecutarPotencia(double basePotencia, double exponentePotencia)
			{
			try
				{
				// Math.Pow no lanza una excepción por lo que nunca se ejecutará el bloque catch ni se retornará el valor 0
				double resultado = Math.Pow(basePotencia, exponentePotencia);
				return resultado;
				}
			catch (ArgumentOutOfRangeException)
				{
				lblResultado.Text = "Numero fuera\nde rango.";
				return 0;
				}
			}


		}
	}
