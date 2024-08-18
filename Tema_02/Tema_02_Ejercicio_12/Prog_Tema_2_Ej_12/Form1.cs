using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_12
	{
	public partial class Prog_Tema_2_Ej_12 : Form
		{
		public Prog_Tema_2_Ej_12()
			{
			InitializeComponent();
			}

		private void btnImporte_Click(object sender, EventArgs e)
			{
			lblImporte.Text = "Importe:\n";
			try
				{

				}
			catch (FormatException)
				{
				MessageBox.Show("Introduzca números.");
				}
			}
		}
	}
