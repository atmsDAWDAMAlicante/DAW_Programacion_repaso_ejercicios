using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_08
	{
	public partial class Prog_Tema_2_Ej_08 : Form
		{
		public Prog_Tema_2_Ej_08()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Resultado:\n";
			try
				{
				// Declaración, inicialización y conversión a int de las tres variables que recogen los valores de los TextBox
				int num1 = int.Parse(txtNum1.Text);
				int num2 = int.Parse(txtNum2.Text);
				int num3 = int.Parse(txtNum3.Text);

				// Dos variables que recogen cada operación
				int suma = num1 + num2 + num3;
				int producto = num1 * num2 * num3;

				// Impresión por pantalla de los resultados
				lblResultado.Text += $"Suma = {suma}\nProducto = {producto}";
				}

			catch (FormatException)
				{
				MessageBox.Show("Introduzca números.");
				}
			}
		}
	}
