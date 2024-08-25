using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_10
	{
	public partial class Prog_Tema_3_Ej_10 : Form
		{
		public Prog_Tema_3_Ej_10()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{

			// Declaración e inicialización de las variables que se utilizarán
			// Como los euros tienen decimales se declaran doubles y no enteros
			double unidades = 0;
			string tipoMoneda = "billete/s";

			// Con este método se evalúa si lo introducido es un número y lo convierte en un double; y si no lo es, la variable booleana
			// devuelve false, por lo que se imprimirá un string indicando que "Introduce números."
			// No se utiliza try-catch para manejar esta circunstancia
			bool numesnum = double.TryParse(txtEuros.Text, out double cantidad);

			if (numesnum)
				{
				lblResultado.Text = $"{cantidad} {unidades} {tipoMoneda}";
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}
			}
		}
	}
