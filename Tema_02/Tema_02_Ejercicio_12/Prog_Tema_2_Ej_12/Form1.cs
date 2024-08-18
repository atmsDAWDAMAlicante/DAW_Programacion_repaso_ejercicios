using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_12
	{
	public partial class Prog_Tema_2_Ej_12 : Form
		{
		public Prog_Tema_2_Ej_12()
			{
			InitializeComponent();
			}

		private void btnImporte_Click(object sender, EventArgs e)
			{
			lblImporte.Text = "Importe:\n";
			// Declaración de la constante double que guarda el tipo de IVA
			const double IVA = 21;
			try
				{
				// Declaración, inicialización y conversión de las variables que recogen los valores de los TextBox
				double producto1 = double.Parse(txtProducto1.Text);
				double producto2 = double.Parse(txtProducto2.Text);
				double producto3 = double.Parse(txtProducto3.Text);

				// Declaración y cálculo de los importes, con y sin IVA, y el propio importe del IVA soportado
				double subtotal = producto1 + producto2 + producto3;
				double IVAsoportado = subtotal * (IVA / 100);
				double total = subtotal + IVAsoportado;

				// Impresión del resultado en pantalla
				lblImporte.Text += $"----- subtotal: {subtotal} €\n----- {IVA}% de IVA: {IVAsoportado} €\n----- total a pagar: {total} €";
				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números.");
				}
			}
		}
	}
