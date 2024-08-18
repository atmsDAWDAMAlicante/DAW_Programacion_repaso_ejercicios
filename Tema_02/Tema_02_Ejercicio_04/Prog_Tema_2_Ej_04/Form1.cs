using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_04
	{
	public partial class Prog_Tema_2_Ej_04 : Form
		{
		public Prog_Tema_2_Ej_04()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Resultado:\n";

			// Declaración de las dos variables enteros
			int num1, num2;
			lblResultado.Text += "- Declaración de dos varialbes enteros num1 y num2\n";

			// Inicialización de las dos variables
			num1 = 2;
			num2 = 3;
			lblResultado.Text += "- Inicialización de las dos variables num1 = 2 y num2 = 3\n";

			//Declaración de la variable entera resultado que recoge la suma de num1 + num2
			int resultado = num1 + num2;
			lblResultado.Text += "- Declaración de la variable entera 'resultado' que\nrecoge la suma de num1 + num2\n";

			// Impresión del resultado en un MessageBox
			MessageBox.Show(resultado.ToString());
			lblResultado.Text += "- Impresión del resultado de la suma = " + resultado.ToString();
			}
		}
	}
