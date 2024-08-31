using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_20
	{
	public partial class Prog_Tema_3_Ej_20 : Form
		{
		public Prog_Tema_3_Ej_20()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			bool baseEsNum = int.TryParse(txtBase.Text, out int basePotencia); // la palabra 'base' es una palabra reservada
			bool exponenteEsNum = int.TryParse(txtExponente.Text, out int exponente);
			int resultado = 1;
			if ((baseEsNum) && (exponenteEsNum))
				{
				// La variable 'exponente' determina el número de vueltas que debe repetirse el bucle
				for (int i = 0; i < exponente; i++)
					{
					// 'resultado' recoge tantas multiplicaciones de si misma con 'basePotencia' como vueltas marque 'exponente'
					// Al ser una multiplicación, 'resultado' no puede tomar el valor inicial 0
					resultado *= basePotencia;
					}
				lblResultado.Text = resultado.ToString();
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}



			}
		}
	}
