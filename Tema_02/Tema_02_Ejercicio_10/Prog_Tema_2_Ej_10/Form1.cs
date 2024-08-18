using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_10
	{
	public partial class Prog_Tema_2_Ej_10 : Form
		{
		public Prog_Tema_2_Ej_10()
			{
			InitializeComponent();
			}

		private void btnPasaraPesetas_Click(object sender, EventArgs e)
			{
			try
				{
				// Declaro la variable double 'euros', ya que los euros tienen decimales, y recojo el valor del TextBox y lo convierto a double
				double euros = double.Parse(txtEuros.Text);
				// Declaro la variable entera 'pesetas' que recoge la conversión del double 'euros' con un casting
				int pesetas = (int)(euros*166.386);
				// Se muestra el resultado en el TextBox correspondiente
				txtPesetas.Text = pesetas.ToString();
				}
			catch (FormatException)
			{
				MessageBox.Show("Introduzca números.");
			}
			}

		private void btnPasaraEuros_Click(object sender, EventArgs e)
			{
			try
				{
				// Declaro la variable int 'pesetas', ya que no tenían decimales, y recojo el valor del TextBox y lo convierto a int
				int pesetas = int.Parse(txtPesetas.Text);
				// Declaro la variable double 'euros' que recoge la conversión del int 'pesetas' con un casting
				double euros = ((double)(pesetas)/166.386);
				// Se muestra el resultado en el TextBox correspondiente
				txtEuros.Text = euros.ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números.");
				}
			}
		}
	}
