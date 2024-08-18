using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_14
	{
	public partial class Prog_Tema_2_Ej_14 : Form
		{
		public Prog_Tema_2_Ej_14()
			{
			InitializeComponent();
			}

		// Código de cada botón: se convierte en entero el contenido de cada TextBox y
		// se realiza la comparación, todo entre paréntesis, a cuyo resultado se le aplica ToString()
		// para imprimirlo en el label lblResultado
		private void btnMayorQue_Click(object sender, EventArgs e)
			{
			try 
				{ 
				lblResultado.Text = (int.Parse(txtNum1.Text) > int.Parse(txtNum2.Text)).ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números.");
				}
			}

		private void btnMenorQue_Click(object sender, EventArgs e)
			{
			try
				{
				lblResultado.Text = (int.Parse(txtNum1.Text) < int.Parse(txtNum2.Text)).ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números.");
				}
			}

		private void btnIgualA_Click(object sender, EventArgs e)
			{
			try
				{
				lblResultado.Text = (int.Parse(txtNum1.Text) == int.Parse(txtNum2.Text)).ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números.");
				}
			}

		private void btnDistintoA_Click(object sender, EventArgs e)
			{
			try
				{
				lblResultado.Text = (int.Parse(txtNum1.Text) != int.Parse(txtNum2.Text)).ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números.");
				}
			}
		}
	}
