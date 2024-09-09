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
				ImpresionResultado(EsBisiesto(yearIntroducido), yearIntroducido);
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}
			}

		// Este método EsBisiesto() es el que se evalúa en la prueba unitaria
		// y se puede utilizar en ejercicios posteriores.
		// De este modo queda modularizado el código separando en dos funciones la comprobación de si el año es bisiesto
		// y en otra función ImpresionResultado() la impresión del resultado en función de si el año es o no bisiesto
		public bool EsBisiesto(int yearIntroducido) 
			{
			// Con arreglo a la formulación literal del enunciado:
			// "Los Años bisiestos son los divisibles por 4 excepto los divisibles por 100 y no divisibles por 400."
			// Desgranando dicho enunciado:
			// a) "Los Años bisiestos son los divisibles por 4" equivale a yearIntroducido%4==0
			// b) "excepto los divisibles por 100" equivale a !(yearIntroducido%100==0) Atención a la negación ! que es el 'excepto'
			// c) "y no divisibles por 400" equivale a  yearIntroducido%400!=0
			if ( (yearIntroducido%4==0) && !(yearIntroducido%100==0) && (yearIntroducido%400!=0) )
				{
				return true;
				}
			else
				{
				return false;
				}
			}

		public void ImpresionResultado(bool resultado, int yearIntroducido)
			{
			if (resultado)
				{
				lblResultado.Text = $"{yearIntroducido} SÍ es bisiesto.";
				}
			else
				{
				lblResultado.Text = $"{yearIntroducido} NO es bisiesto.";
				}
			}
		}
	}
