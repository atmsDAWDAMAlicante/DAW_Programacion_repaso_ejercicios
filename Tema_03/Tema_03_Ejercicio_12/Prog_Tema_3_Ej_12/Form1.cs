using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_12
	{
	public partial class Prog_Tema_3_Ej_12 : Form
		{
		string salida = "";
		public Prog_Tema_3_Ej_12()
			{
			InitializeComponent();

			}

		private void btnBucleFor_Click(object sender, EventArgs e)
			{

			lblResultado.Text = "";

			bool numEsNumFor = int.TryParse(txtNumero.Text, out int numeroFor);

			if (numEsNumFor)
				{
				// Bucle For
				for (int i = 0; i < numeroFor; i++)
					{
					lblResultado.Text += $"{i}+";
					}
				lblTipoBucle.Text = "Bucle For";
				}
			else
				{
				lblResultado.Text = "Introduce números";
				lblTipoBucle.Text = "";
				}
			}

		private void btnBucleWhile_Click(object sender, EventArgs e)
			{

			lblResultado.Text = "";

			bool numEsNumWhile = int.TryParse(txtNumero.Text, out int numeroWhile);

			// Se declara e inicializa a 0 una variable entera que hará de contador para que en el bucle While se pueda 
			// evaluar que se ha alcanzado el límite

			int contador = 0;

			// Bucle While
			if (numEsNumWhile)
				{
				while (contador < numeroWhile)
					{
					lblResultado.Text += $"{contador}+";
					contador++;
					}
				lblTipoBucle.Text = "Bucle While";
				}
			else
				{
				lblResultado.Text = "Introduce números";
				lblTipoBucle.Text = "";
				}
			}

			private void btnBucleDoWhile_Click(object sender, EventArgs e)
			{



			lblResultado.Text = "";
			bool numEsNumDoWhile = int.TryParse(txtNumero.Text, out int numeroDoWhile);

			// Se declara e inicializa a 0 una variable entera que hará de contador para que en el bucle Do... While se pueda 
			// evaluar que se ha alcanzado el límite

			int contador = 0;

			if (numEsNumDoWhile)
				{
				// Bucle Do While
				do
					{
						lblResultado.Text += $"{contador}+";
						contador++;
					} while (contador < numeroDoWhile);
				lblTipoBucle.Text = "Bucle Do While";
				}
			else
				{
				lblResultado.Text = "Introduce números";
				lblTipoBucle.Text = "";
				}
			}
		}
	}
