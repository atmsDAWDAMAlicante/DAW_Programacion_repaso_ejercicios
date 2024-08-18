using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_11
	{
	public partial class Prog_Tema_2_Ej_11 : Form
		{
		public Prog_Tema_2_Ej_11()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Resultado anual:\n";
			try
				{
				// Declaración de dos variables double que recogen los valores de los TextBox
				double saldo = double.Parse(txtSaldo.Text);
				double interes = double.Parse(txtInteres.Text);
				// La variable resultado suma al saldo los intereses calculados con (saldo * (interes/100))
				double resultado = saldo + (saldo * (interes/100));
				// Se imprime por pantalla el resultado
				lblResultado.Text += resultado.ToString();
				}
			catch 
				{
				MessageBox.Show("Introduzca números");
				}
			}
		}
	}
