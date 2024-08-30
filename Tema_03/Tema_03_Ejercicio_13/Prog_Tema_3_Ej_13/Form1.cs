using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_13
	{
	public partial class Prog_Tema_3_Ej_13 : Form
		{
		public Prog_Tema_3_Ej_13()
			{
			InitializeComponent();
			}

		private void btnBucleFor_Click(object sender, EventArgs e)
			{

			lblResultado.Text = "";

			bool numEsNum = int.TryParse(txtNumero.Text, out int numeroFor);

			if (numEsNum)
				{
				lblTipoBucle.Text = "Bucle For";

				for (int i = 0; i < numeroFor; i++)
					{
					// Bloque condicional dentro del bucle que evaluará si el número i es par para concatenarlo al label
						if (i % 2 == 0)
						{
						lblResultado.Text += $"{i}+";
						}
					}

				}
			else
				{
				lblResultado.Text = "Introduce números.";
				lblTipoBucle.Text = "";
				}


			}

		private void btnBucleWhile_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			bool numEsNum = int.TryParse(txtNumero.Text, out int numeroWhile);

			int contador = 0;

			if (numEsNum)
				{
				lblTipoBucle.Text = "Bucle While";
				while ( contador < numeroWhile)
					{
					// Bloque condicional dentro del bucle que evaluará si el número i es par para concatenarlo al label
					if (contador%2 == 0)
						{
						lblResultado.Text += $"{contador}+";
						}
					// La variable contador se incrementa fuera del bloque condicional
					contador++;
					}
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				lblTipoBucle.Text = "";
				}
			}

		private void btnDoWhile_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			bool numEsNum = int.TryParse(txtNumero.Text, out int numeroDoWhile);

			int contador = 0;

			if (numEsNum)
				{
				lblTipoBucle.Text = "Bucle Do... While";
				do
					{
					// Bloque condicional dentro del bucle que evaluará si el número i es par para concatenarlo al label
					if (contador%2 == 0)
						{
						lblResultado.Text += $"{contador}+";
						}
					// La variable contador se incrementa fuera del bloque condicional
					contador++;
					} while (contador <  numeroDoWhile);
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				lblTipoBucle.Text = "";
				}
			}
		}
	}
