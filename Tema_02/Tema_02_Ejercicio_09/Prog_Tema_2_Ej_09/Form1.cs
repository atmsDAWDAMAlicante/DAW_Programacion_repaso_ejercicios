using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_09
	{
	public partial class Prog_Tema_2_Ej_09 : Form
		{
		public Prog_Tema_2_Ej_09()
			{
			InitializeComponent();
			}

		private void btnSuma_Click(object sender, EventArgs e)
			{
			try
				{
				int operacion = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
				txtResultado.Text = operacion.ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduce números");
				}
			}

		private void btnResta_Click(object sender, EventArgs e)
			{
			try
				{
				int operacion = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
				txtResultado.Text = operacion.ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduce números");
				}
			}

		private void btnMultiplicacion_Click(object sender, EventArgs e)
			{
			try
				{
				int operacion = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
				txtResultado.Text = operacion.ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduce números");
				}
			}

		private void btnDivision_Click(object sender, EventArgs e)
			{
			try
				{
				int operacion = int.Parse(txtNum1.Text) / int.Parse(txtNum2.Text);
				txtResultado.Text = operacion.ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduce números");
				}
			catch (DivideByZeroException)
				{
				MessageBox.Show("Error: división por cero");
				}
			}

		private void btnResto_Click(object sender, EventArgs e)
			{
			try
				{
				int operacion = int.Parse(txtNum1.Text) % int.Parse(txtNum2.Text);
				txtResultado.Text = operacion.ToString();
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduce números");
				}
			}
		}
	}
