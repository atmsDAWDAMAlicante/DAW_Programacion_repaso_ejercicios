using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prog_Tema_3_Ej_15
	{
	public partial class Prog_Tema_3_Ej_15 : Form
		{
		public Prog_Tema_3_Ej_15()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			// Pasos para activar el InputBox 
			// 1º Ir al explorador de soluciones y hacer click con el botón derecho sobre Referencias y escoger Agregar referencias
			// 2º En la siguiente ventana activar el check de Microsoft.VisualBasic y aceptar
			// 3º Comprobar en el código del Form que está la directiva using Microsoft.VisualBasic; (si no, ponerla arriba)
			// InputBox es un método de Interaction: Interaction.InputBox("Mensaje a mostrar en la venana");
			// Lo que se introduzca a través de un InputBox se almacena en una variable string

			bool numEsNum = int.TryParse(Interaction.InputBox("Introduce un número"), out int numero);
			if (numEsNum)
				{
				MessageBox.Show(numero.ToString());
				}
			else
				{
				MessageBox.Show("Introduce números");
				}
			}
		}
	}
