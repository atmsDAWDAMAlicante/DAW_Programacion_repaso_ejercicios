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
				lblResultado.Text = EsBisiesto(yearIntroducido); // la función devuelve un string para evaluarlo en la prueba unitaria
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}
			}

		public string EsBisiesto(int yearIntroducido)
			{
			// Con arreglo a la formulación literal del enunciado:
			// "Los Años bisiestos son los divisibles por 4 excepto los divisibles por 100 y no divisibles por 400."
			// Desgranando dicho enunciado:
			// a) "Los Años bisiestos son los divisibles por 4" equivale a yearIntroducido%4==0
			// b) "excepto los divisibles por 100" equivale a !(yearIntroducido%100==0) Atención a la negación ! que es el 'excepto'
			// c) "y no divisibles por 400" equivale a  yearIntroducido%400!=0
			if ( (yearIntroducido%4==0) && !(yearIntroducido%100==0) && (yearIntroducido%400!=0) )
				{
				return $"{yearIntroducido} SÍ es bisiesto.";
				}
			else
				{
				return $"{yearIntroducido} NO es bisiesto.";
				}
			}
		}
	}
