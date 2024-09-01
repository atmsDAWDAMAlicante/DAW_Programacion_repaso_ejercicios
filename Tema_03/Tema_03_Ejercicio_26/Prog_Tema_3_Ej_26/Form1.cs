using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_26
	{
	public partial class Prog_Tema_3_Ej_26 : Form
		{
		public Prog_Tema_3_Ej_26()
			{
			InitializeComponent();
			}

		private void btnMostrar_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			// Se declara e inicializa una variable entero 'contadorLinea'.
			// Se inicializa a 8 que es un valor superiora 7 (los elementos permitidos por línea)
			// Cada vez que se alcance un múltiplo de 7, la variable saltoLinea tomará el valor "\n" para llevar a efecto el salto de línea
			// Este condicional se evalúa dentro del bucle for
			int contadorLinea = 8;
			string saltoLinea;

			for (int i = 1; i < 101; i++) 
				{
				if (contadorLinea % 7 == 0)
					{
					saltoLinea = "\n";
					}
				else
					{
					saltoLinea = "";
					}
				// Este bloque condicional if evalúa si el contador 'i' del bucle for es múltiplo de 3
				// Si lo es, lo imprime por pantalla e incrementa la variable 'contadorLinea' (la que identifica los elementos que hay en cadaa línea)
				if (i % 3 == 0)
					{
					lblResultado.Text += $"{i} - {saltoLinea}";
					contadorLinea++;
					}
				}
			}
		}
	}
