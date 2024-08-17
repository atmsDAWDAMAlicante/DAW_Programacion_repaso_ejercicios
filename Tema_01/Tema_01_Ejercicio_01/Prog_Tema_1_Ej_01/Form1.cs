using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_1_Ej_01
	{
	public partial class Prog_Tema_1_Ej_01 : Form
		{
		public Prog_Tema_1_Ej_01()
			{
			InitializeComponent();
			}

		private void btnBoton1_Click(object sender, EventArgs e)
			{
			MessageBox.Show("Se ha apretado el primer botón.");
			}

		private void btnBoton2_Click(object sender, EventArgs e)
			{
			MessageBox.Show("Se ha apretado el segundo botón.");
			}
		}
	}
