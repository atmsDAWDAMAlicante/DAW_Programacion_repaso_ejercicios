using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_13
	{
	public partial class Prog_Tema_3_Ej_13 : Form
		{
		public Prog_Tema_3_Ej_13()
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

		private void btnDoWhile_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Bucle Do While";
			}
		}
	}
