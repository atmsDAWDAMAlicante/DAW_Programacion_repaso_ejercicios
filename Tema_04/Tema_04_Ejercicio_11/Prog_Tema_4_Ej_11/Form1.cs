using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_11_
	{
	public partial class Prog_Tema_4_Ej_11 : Form
		{
		public Prog_Tema_4_Ej_11()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			bool numEsNum = int.TryParse(txtYear.Text, out int yearIntroducido);

			if (numEsNum)
				{
				lblResultado.Text = EsBisiesto(yearIntroducido);
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}

			}

		public string EsBisiesto(int yearIntroducido)
			{


			return $"{yearIntroducido}";
			}



		}
	}
