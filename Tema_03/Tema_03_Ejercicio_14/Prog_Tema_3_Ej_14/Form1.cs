using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_14
	{
	public partial class Prog_Tema_3_Ej_14 : Form
		{
		public Prog_Tema_3_Ej_14()
			{
			InitializeComponent();
			}

		// Para comprobar el resultado: el sumatorio de 100 = 5050

		private void btnBucleFor_Click(object sender, EventArgs e)
			{
			bool numEsNum = int.TryParse(txtNumero.Text, out int numero);
			// Se declara y define la variable entera resultado que recogerá la suma de cada valor que tome i
			int resultado = 0;
			if (numEsNum)
				{
				for (int i = 0; i < numero; i++)
					{
					// En cada vuelta del bucle se actualiza (suma) la variable resultado
					// Se suma i+1 para que no comience la suma por el valor 0
					resultado += (i+1);
					}
				lblResultado.Text = $"Bucle For: {resultado}";
				}
			else
				{
				lblResultado.Text = "Introduce números";
				}
			}

		private void btnBucleWhile_Click(object sender, EventArgs e)
			{
			bool numEsNum = int.TryParse(txtNumero.Text, out int numero);
			int contador = 0;
			int resultado = 0;
			if (numEsNum)
				{
				while (contador < numero)
					{
					// La variable contador se incrementa antes de la suma para que no comience la suma por el valor 0
					contador++;
					// En cada vuelta del bucle se actualiza (suma) la variable resultado
					resultado += contador;
					}
				lblResultado.Text = $"Bucle While: {resultado}";

				}
			else
				{
				lblResultado.Text = "Introduce números";
				}
			}
		}
	}
