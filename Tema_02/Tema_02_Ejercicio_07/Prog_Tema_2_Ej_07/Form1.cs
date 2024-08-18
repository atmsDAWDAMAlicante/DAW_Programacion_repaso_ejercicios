using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_07
	{
	public partial class Prog_Tema_2_Ej_07 : Form
		{
		public Prog_Tema_2_Ej_07()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Resultado.\n";
			try
				{
				// Declaración, inicialización y conversión de la variable que recogerá el número del TextBox
				int altura = int.Parse(txtNumero.Text);

				// Declaración de las variables que recogerán los resultados
				int metros, centimetros;

				// Operaciones:
				// los metros se obtienen dividiendo el número introducido dividido por 100
				metros = altura / 100;
				// los centímetros se obtienen restando al número introducido el resultado de metros * 100
				centimetros = altura - (metros*100);

				// Impresión del resultado en el formulario
				lblResultado.Text += $"Metro/s: {metros}\nCentímetros: {centimetros}";	
				}
			catch (FormatException)
			{
				MessageBox.Show("Introduce un número entero");
			}
			}
		}
	}
