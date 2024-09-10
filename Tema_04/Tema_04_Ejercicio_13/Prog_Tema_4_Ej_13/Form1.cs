using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_13_
	{
	public partial class Prog_Tema_4_Ej_13 : Form
		{
		public Prog_Tema_4_Ej_13()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			// Variables
			lblResultado.Text = "";
			bool diaEsNum = int.TryParse(txtDia.Text, out int diaNum);
			bool mesEsNum = int.TryParse(txtMes.Text, out int mesNum);
			bool yearEsNum = int.TryParse(txtYear.Text, out int yearNum);
			bool bisiesto;

			// A) Llamada a los métodos para validar los datos introducidos

			// Primero se valida que lo introducido en los TextBox son números
			if (diaEsNum && mesEsNum && yearEsNum)
				{
				// Segundo se valida que se ha introducido en el TextBox del año un número de cuatro dígitos
				if (yearNum.ToString().Length == 4)
					{
					// Tercero, se llama al método que evalúa si el año introducido es bisiesto
					bisiesto = EsBisiesto(yearNum);
					// Cuarto, se llama al método que evalúa si la fecha introducida es válida
					if(ValidarFechaIntroducida(diaNum, mesNum, bisiesto))
						{
						// sumar un día
						}
					else
						{
						lblResultado.Text = "Introduce una fecha válida.";
						}
					}
				else
					{
					lblResultado.Text = "Introduce un número\nde cuatro dígitos.";
					}
				}
			else
				{
				lblResultado.Text = "Introduce números.";
				}

			// 2. Llamadas a métodos para sumar un día más



			// 3. Llamadas a métodos para validar los datos introducidos


			}


		// Módulos

		// 1. Métodos para validar los datos introducidos

		// 1.1 - Método EsBisiesto: se encarga de comprobar si el año introducido es bisiesto
		public bool EsBisiesto(int year)
			{
			if ( (year%4==0) && (!(year%100==0)) && (year%400!=0) )
				return true;
			else
				{
				return false;
				}
			}

		public bool ValidarFechaIntroducida (int dia, int mes, bool bisiesto)
			{
			return true;
			}

		// 2. Métodos para incrementar un día sobre los datos introducidos y validados

		public void SumarDia()
			{
			// sumar dia
			}


		// 3. Método para dar formato a la fecha introducida, validada e incrementada

		public string FormatearFecha()
			{
			return "";
			}

		}
	}
