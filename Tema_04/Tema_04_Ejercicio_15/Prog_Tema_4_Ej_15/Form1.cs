using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_15_
	{
	public partial class Prog_Tema_4_Ej_15 : Form
		{
		public Prog_Tema_4_Ej_15()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			bool importeEsNum = double.TryParse(txtEuros.Text, out double importeIntroducido);

			if ((importeEsNum) && (importeIntroducido > 0))
				{

				}
			else
				{
				lblResultado.Text = "Introduzca una cantidad positiva.";
				}



			}
		}
	}
