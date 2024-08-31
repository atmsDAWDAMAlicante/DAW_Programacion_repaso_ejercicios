using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_24
	{
	public partial class Prog_Tema_3_Ej_24 : Form
		{
		public Prog_Tema_3_Ej_24()
			{
			InitializeComponent();
			}

		private void btnMostrar_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			bool numEsNum = int.TryParse(txtNumero.Text, out int numero);

			if (numEsNum)
				{
				if ((numero > 0) && (numero <= 100))
					{
					for (int i = 1; i < 11; i++)
					// Alternativa del código de definición del bucle for, en consonancia con la alternativa comentada abajo
					//for (int i = 0; i < 10; i++)
						{
						lblResultado.Text += $"{numero} * {i} = {numero * i}\n";
						// Alternativa a este código para imprimir el resultado por pantalla
						//lblResultado.Text += $"{numero} * {i+1} = {numero * (i+1)}\n";
						}
					}
				else
					{
					lblResultado.Text = "Introduce un número\nentre el 1 y el 100";
					}
				}
			else
				{
				lblResultado.Text = "Introduce números";
				}
			}
		}
	}
