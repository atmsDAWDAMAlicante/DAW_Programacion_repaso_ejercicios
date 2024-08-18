using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_05
	{
	public partial class Prog_Tema_2_Ej_05 : Form
		{
		public Prog_Tema_2_Ej_05()
			{
			InitializeComponent();
			}

		private void btnSuma_Click(object sender, EventArgs e)
			{
			try
				{
				// Declaración, inicialización de las variables que recogen los números de los cuadros de texto y su conversión a enteros
				int num1 = int.Parse(txtNum1.Text);
				int num2 = int.Parse(txtNum2.Text);
				// Declaración de la variable que recoge la suma
				int resultado = num1 + num2;
				// Muestra de la variable resultado en el cuadro de texto (string)
				txtResulado.Text = resultado.ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números en los cuadros de texto.");
				}
			}

		private void btnResta_Click(object sender, EventArgs e)
			{
			try
				{
				// Declaración, inicialización de las variables que recogen los números de los cuadros de texto y su conversión a enteros
				int num1 = int.Parse(txtNum1.Text);
				int num2 = int.Parse(txtNum2.Text);
				// Declaración de la variable que recoge la resta
				int resultado = num1 - num2;
				// Muestra de la variable resultado en el cuadro de texto (string)
				txtResulado.Text = resultado.ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números en los cuadros de texto.");
				}
			}
		}
	}
