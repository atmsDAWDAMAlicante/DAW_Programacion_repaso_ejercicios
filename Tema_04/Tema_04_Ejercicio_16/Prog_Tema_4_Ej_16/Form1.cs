using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_16_
	{
	public partial class Prog_Tema_4_Ej_16 : Form
		{
		public Prog_Tema_4_Ej_16()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";
			bool numEsNum = long.TryParse(txtNumero.Text, out long numero);

			if (numEsNum)
				{

				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}

			}
		public long CalcularFactorial()
			{
			return 0;
			}

		}
	}
