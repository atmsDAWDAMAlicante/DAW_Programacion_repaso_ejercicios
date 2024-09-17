using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_14_
	{
	public partial class Prog_Tema_4_Ej_14 : Form
		{
		public Prog_Tema_4_Ej_14()
			{
			InitializeComponent();
			}

		private void btnSuCambio_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";
			int fraccion = 10000;
			bool entradaEsNum = int.TryParse(txtCantidad.Text, out int cantidad);
			if (entradaEsNum)
				{
				do
					{
					if (cantidad > fraccion)
						{
						ImprimirResultado((cantidad - fraccion).ToString());
						}
					cantidad -= 5000;
					} while (cantidad > 0);
				}
			else
				{
				lblResultado.Text = "Introduzca números.";
				}
			}

		public int CalcularUnidades(int cantidad, int fraccion)
			{
			return 1;
			}
		public void ImprimirResultado(string nuevaLinea)
			{
			lblResultado.Text += $"{nuevaLinea}\n";
			}



		}
	}
