using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_22
	{
	public partial class Prog_Tema_3_Ej_22 : Form
		{
		public Prog_Tema_3_Ej_22()
			{
			InitializeComponent();
			}

		private void btnComprobar_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";

			bool numEsNum = int.TryParse(txtNumero.Text, out int numero);

			if (numEsNum)
				{ // En este bloque if se establece un límite en la entrada de números (aunque no lo indica el enunciado)
				if ((numero >= 14000) && (numero <= 120000))
					{
					// Este segundo bloque if evalúa que los números introducidos están dentro de uno de los tres rangos
					// para ello se establece la disyuntiva || entre los tres rangos y, dentro de cada uno se establecen los rangos con &&
					if ( ((numero >= 14681) && (numero <= 15681)) || ((numero >= 70001) && (numero <= 79999)) || ((numero >= 88888) && (numero <= 111111)) )
						{
						lblResultado.Text = $"El respuesto {numero} es defectuoso";
						}
					else 
						{
						lblResultado.Text = $"El respuesto {numero} NO es defectuoso";
						}
					}
				else
					{
					lblResultado.Text = "Introduce un número entre 14.000 y 120.000";
					}
				}

			else
				{
				lblResultado.Text = "Introduce números.";
				}
			}
		}
	}
