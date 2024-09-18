using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_15_
	{
	public partial class Prog_Tema_4_Ej_15 : Form
		{
		public Prog_Tema_4_Ej_15()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			// Declaración de las variables
			int unidades; // La variable 'unidades' irá recogiendo el número de billetes o monedas por fracción
			double centimos; // La variable 'centimos' servirá para descontar la cantidad una vez baje de 1 € de importe
			string centimosEuros = "€"; // Esta variable 'centimosEuros' modifica el string "€" a "cts" cuando baja de un € el importe.

			bool importeEsNum = double.TryParse(txtEuros.Text, out double importeIntroducido);

			if ((importeEsNum) && (importeIntroducido > 0))
				{

				// La cantidad introducida en el TextBox se irá pasando por referencia y se irá descontando cada vez que se obtengan las unidades
				// A continuación se envían los resultados obtenidos a la función 'ImprimirResultado()' donde se van concatenando
				unidades = CalcularUnidades(ref importeIntroducido, 500);
				ImprimirResultado(unidades, 500, centimosEuros);

				unidades = CalcularUnidades(ref importeIntroducido, 200);
				ImprimirResultado(unidades, 100, centimosEuros);

				unidades = CalcularUnidades(ref importeIntroducido, 100);
				ImprimirResultado(unidades, 100, centimosEuros);

				unidades = CalcularUnidades(ref importeIntroducido, 50);
				ImprimirResultado(unidades, 50, centimosEuros);

				unidades = CalcularUnidades(ref importeIntroducido, 20);
				ImprimirResultado(unidades, 20, centimosEuros);

				unidades = CalcularUnidades(ref importeIntroducido, 10);
				ImprimirResultado(unidades, 10, centimosEuros);

				unidades = CalcularUnidades(ref importeIntroducido, 5);
				ImprimirResultado(unidades, 5, centimosEuros);

				unidades = CalcularUnidades(ref importeIntroducido, 2);
				ImprimirResultado(unidades, 2, centimosEuros);

				unidades = CalcularUnidades(ref importeIntroducido, 1);
				ImprimirResultado(unidades, 1, centimosEuros);

				// Cuando el importeIntroducido desciende de la cantidad correspondiente a un euro la variable 'centimosEuros' pasa a valer "cts"
				centimosEuros = "cts";

				// Para evitar la desviación de los decimales en la cantidad a descontar
				// la almaceno en la variable 'centimos' = 'importeIntroducido * 101... PARA QUE DEVUELVA EL CÉNTIMO!!!!!!!
				// A partir de aquí se llama a la función CalcularCentimos() para obtener las unidades de céntimos


				centimos = importeIntroducido * 101;

				unidades = CalcularCentimos(ref centimos, 50);
				ImprimirResultado(unidades, 50, centimosEuros);

				unidades = CalcularCentimos(ref centimos, 20);
				ImprimirResultado(unidades, 20, centimosEuros);

				unidades = CalcularCentimos(ref centimos, 10);
				ImprimirResultado(unidades, 10, centimosEuros);

				unidades = CalcularCentimos(ref centimos, 5);
				ImprimirResultado(unidades, 5, centimosEuros);

				unidades = CalcularCentimos(ref centimos, 2);
				ImprimirResultado(unidades, 2, centimosEuros);

				unidades = CalcularCentimos(ref centimos, 1);
				ImprimirResultado(unidades, 1, centimosEuros);
				
				}
			else
				{
				lblResultado.Text = "Introduzca una cantidad positiva.";
				}

		

			}

		public int CalcularUnidades(ref double centimos, double fraccion)
			{
				double unidades = (centimos / fraccion);
				unidades = (int)unidades;
				centimos -= (fraccion * (double)unidades);
				return ((int)unidades);
			}

		public int CalcularCentimos(ref double centimos, double fraccion)
			{
			double unidades = (centimos / fraccion);
			unidades = (int)unidades;
			centimos -= (fraccion * (double)unidades);
			return ((int)unidades);
			}




		public void ImprimirResultado(int unidades, int fraccion, string centimosEuros)
			{
			string tipoCambio = "";
			string plural = "";

			// Un gran bloque condicional discrimina si se trata de euros o céntimos para distinguir, en el caso de los euros, entre monedas o billetes
			if (centimosEuros != "cts")
				{ 
					if (fraccion > 2)
					{
						tipoCambio = "billete";
					}
					else
					{
						tipoCambio = "moneda";
					}
				}

				if (unidades > 1)
					{
					plural = "s";
					}
				else
					{
					plural = "";
					}

			if (unidades > 0) { 
				lblResultado.Text += $"{unidades} {tipoCambio}{plural} de {fraccion} {centimosEuros}\n";
				}
			}



		}
	}
