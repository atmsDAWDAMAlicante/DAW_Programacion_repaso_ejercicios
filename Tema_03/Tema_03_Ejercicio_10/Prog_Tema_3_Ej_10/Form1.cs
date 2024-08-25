using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_10
	{
	public partial class Prog_Tema_3_Ej_10 : Form
		{
		public Prog_Tema_3_Ej_10()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{

			// Declaración e inicialización de las variables que se utilizarán
			// Como los euros tienen decimales se declaran doubles y no enteros
			// Prueba el programa con el importe 1888,88 que recorre todos los billetes y monedas
			double unidades;
			double resto;
			double centimos;
			string tipoMoneda = "billete/s";
			string moneda = "euros";

			// Con este método se evalúa si lo introducido es un número y lo convierte en un double; y si no lo es, la variable booleana
			// devuelve false, por lo que se imprimirá un string indicando que "Introduce números."
			// No se utiliza try-catch para manejar esta circunstancia
			bool numesnum = double.TryParse(txtEuros.Text, out double cantidad);

			if (numesnum)
				{
				// Si la cantidad introducida es positiva se inicia los condicionales que indican los billetes y monedas
				if (cantidad > 0) 
					{
					lblResultado.Text = "";


					// Billetes de 500 euros
					if (cantidad >= 500)
						{
						resto = (cantidad % 500);
						unidades = (cantidad - resto) / 500;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 500 {moneda}\n";

						cantidad -= (unidades * 500);
						}


					// Billetes de 200 euros
					if (cantidad >= 200)
						{
						resto = (cantidad % 200);
						unidades = (cantidad - resto) / 200;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 200 {moneda}\n";

						cantidad -= (unidades * 200);
						}


					// Billetes de 100 euros
					if (cantidad >= 100)
						{
						resto = (cantidad % 100);
						unidades = (cantidad - resto) / 100;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 100 {moneda}\n";

						cantidad -= (unidades * 100);
						}


					// Billetes de 50 euros
					if (cantidad >= 50)
						{
						resto = (cantidad % 50);
						unidades = (cantidad - resto) / 50;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 50 {moneda}\n";

						cantidad -= (unidades * 50);
						}


					// Billetes de 20 euros
					if (cantidad >= 20)
						{
						resto = (cantidad % 20);
						unidades = (cantidad - resto) / 20;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 20 {moneda}\n";

						cantidad -= (unidades * 20);
						}


					// Billetes de 10 euros
					if (cantidad >= 10)
						{
						resto = (cantidad % 10);
						unidades = (cantidad - resto) / 10;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 10 {moneda}\n";

						cantidad -= (unidades * 10);
						}


					// Billetes de 5 euros
					if (cantidad >= 5)
						{
						resto = (cantidad % 5);
						unidades = (cantidad - resto) / 5;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 5 {moneda}\n";

						cantidad -= (unidades * 5);
						}

					// Ahora la variable tipoMoneda cambia su valor de billete/s a moneda/s
					tipoMoneda = "moneda/s";

					// Monedas de 2 euros
					if (cantidad >= 2)
						{
						resto = (cantidad % 2);
						unidades = (cantidad - resto) / 2;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 2 {moneda}\n";

						cantidad -= (unidades * 2);
						}

					// Monedas de 1 euro
					if (cantidad >= 1)
						{
						resto = (cantidad % 1);
						unidades = (cantidad - resto);
						lblResultado.Text += $"{unidades} {tipoMoneda} de 1 {moneda}\n";

						cantidad -= unidades;

						}
					// Se asigna a la variable centimos el resto del importe pendiente
					centimos = cantidad * 100;

					//Actualizo la variable cantidad para mostrar al final el resto de la operación.
					cantidad -= centimos / 100;


					// Ahora la variable moneda cambia su valor de euros a céntimos
					moneda = "céntimos";

					// Monedas de 50 céntimos
					if (centimos >= 50)
						{
						resto = (centimos % 50);
						unidades = (centimos - resto) / 50;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 50 {moneda}\n";

						centimos -= (unidades * 50);
						}

					// Monedas de 20 céntimos
					if (centimos >= 20)
						{
						resto = (centimos % 20);
						unidades = (centimos - resto) / 20;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 20 {moneda}\n";

						centimos -= (unidades * 20);
						}

					// Monedas de 10 céntimos
					if (centimos >= 10)
						{
						resto = (centimos % 10);
						unidades = (centimos - resto) / 10;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 10 {moneda}\n";

						centimos -= (unidades * 10);
						}

					// Monedas de 5 céntimos
					if (centimos >= 5)
						{
						resto = (centimos % 5);
						unidades = (centimos - resto) / 5;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 5 {moneda}\n";

						centimos -= (unidades * 5);
						}

					// Monedas de 2 céntimos
					if (centimos >= 2)
						{
						resto = (centimos % 2);
						unidades = (centimos - resto) / 2;
						lblResultado.Text += $"{unidades} {tipoMoneda} de 2 {moneda}\n";

						centimos -= (unidades * 2);
						}

					// Monedas de 1 céntimo
					if (centimos >= 1)
						{
						resto = (centimos % 1);
						unidades = (centimos - resto);
						lblResultado.Text += $"{unidades} {tipoMoneda} de 1 {moneda}\n";

						centimos -= unidades;
						}

					// Impresión del resto de la operación
					// Probar el importe 1888,88 que recorre todos los tipos de billetes y monedas
					lblResultado.Text += $"Resto: {cantidad} € / {centimos} cts";
					}




				else
					{
					lblResultado.Text = "Introduce una cantidad mayor que 0";
					}

				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}
			}
		}
	}
