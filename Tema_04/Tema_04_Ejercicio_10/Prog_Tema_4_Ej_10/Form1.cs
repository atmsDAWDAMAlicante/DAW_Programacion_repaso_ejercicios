using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_10_
	{
	public partial class Prog_Tema_4_Ej_10 : Form
		{
		// Se declara una variable global que recogerá el valor de la base convertirda en entero por referencia
		public double baseNumero;
		public Prog_Tema_4_Ej_10()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			lblResultado2.Text = "";
			lblResultado5.Text = "";
			lblResultado7.Text = "";
			double resultadoPotencia;
			
			bool esNumero = ValidarBase(txtBase.Text);

			// Con este número 45435345345345345435345435345345345345435345345345346457587856567567657567567865764756756
			// las potencias con exponente 5 y 7 exceden del rango

			if (esNumero)
				{
				resultadoPotencia = Math.Pow(baseNumero, 2);
				if (!(double.IsInfinity(resultadoPotencia)))
					{
					lblResultado2.Text = $"{Math.Pow(baseNumero, 2)}";
					}
				else
					{
					lblResultado2.Text = "Número fuera de rango";
					}
				resultadoPotencia = Math.Pow(baseNumero, 5);

				if (!(double.IsInfinity(resultadoPotencia)))
					{
					lblResultado5.Text = $"{resultadoPotencia}";
					}
				else
					{
					lblResultado5.Text = "Número fuera de rango";
					}

				resultadoPotencia = Math.Pow(baseNumero, 7);
				if (!(double.IsInfinity(resultadoPotencia)))
					{
					lblResultado7.Text = $"{resultadoPotencia}";
					}
				else
					{
					lblResultado7.Text = "Número fuera de rango";
					}
				}
			}

		public bool ValidarBase(string stringBase)
			{
			bool resultadoConversion = double.TryParse(stringBase, out baseNumero); // aquí toma valor la variable global baseNumero
			if (resultadoConversion)
				{
				lblSubtituloResultado.Text = "El resutlado es:";
				return true;
				}
			else
				{
				lblSubtituloResultado.Text = "Introduce números.";
				return false;
				}
			}
		}
	}
