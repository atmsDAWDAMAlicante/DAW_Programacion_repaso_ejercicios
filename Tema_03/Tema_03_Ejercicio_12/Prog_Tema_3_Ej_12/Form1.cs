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
		public Prog_Tema_3_Ej_12()
			{
			InitializeComponent();
			}

		private void btnBucleFor_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Bucle For";
			}

		private void btnBucleWhile_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Bucle While";
			}

		private void btnBucleDoWhile_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Bucle Do While";
			}
		}
	}
