using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
						int nuevoDia = SumarDia(diaNum, mesNum, bisiesto);
						int nuevoMes = SumarMes(nuevoDia, mesNum);
						int nuevoYear = SumarYear(nuevoMes, yearNum);

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

		// 1.2 - Método ValidarFechaIntroducida: 
		public bool ValidarFechaIntroducida (int dia, int mes, bool bisiesto)
			{
			if (((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12)) && ((dia > 0) && (dia < 32)))
				{ 
				return true; 
				}
			else if (((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11) ) && ((dia > 0) && (dia < 31)))
				{
				return true;
				}
			else if ( (mes == 2) && (bisiesto == false) && ((dia > 0) && (dia < 29)))
				{
				return true;
				}
			else if ((mes == 2) && (bisiesto == true) && ((dia > 0) && (dia < 30)))
				{
				return true;
				}
			else 
				{ 
				return false; 
				}
			}



		// 2. Métodos para incrementar un día sobre los datos introducidos y validados

		// 2.1 - Método SumarDia: incrementa un día y, comprueba si es el último de cada mes, en cuyo caso devuelve 1
		public int SumarDia(int dia, int mes, bool bisiesto)
			{
			if ( ( (mes == 4) || (mes == 6) || (mes == 9) || (mes == 11) ) && (dia == 30) ) // día 30 cuando es fin de mes
				{
				return 1;
				}
			else if (((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes == 12)) && (dia == 31)) // 31
				{ // día 31 cuando es fin de mes
				return 1;
				}
			else if ((mes == 2) && (bisiesto == false) && (dia == 28)) // día 28 de febrero de un año no bisiesto
				{
				return 1;
				}
			else if ((mes == 2) && (bisiesto == true) && (dia == 29)) // día 29 de febrero de un año bisiesto
				{
				return 1;
				}
			else // resto de los días
				{ 
				return ++dia;
				}
			}

		// 2.2 - Método SumarMes:  comprueba si es el último día de cada mes, en cuyo caso incrementa el mes
		// Se le pasa el valor de la variable 'nuevoDia' que, si ha tomado el valor 1, significa que se está ante un nuevo mes
		public int SumarMes(int nuevoDia, int mes)
			{
			if ((mes == 12) && (nuevoDia == 1)) // último día del año
				{
				return 1;
				}
			else if (nuevoDia == 1) // cualquier fin de mes
				{
				return ++mes;
				}
			else // resto de los meses
				{
				return mes;
				}
			}

		// 2.3 - Método SumarYear: comprueba si es el último día del año, en cuyo caso lo incrementa
		// Se le pasa el valor de la variable 'nuevoMes' que, si ha tomado el valor 1, significa que se está ante un nuevo año
		public int SumarYear(int nuevoMes, int year)
			{
			if (nuevoMes == 1)
				{
				return ++year;
				}
			else 
				{ 
				return year; 
				}
			}




		// 3. Método para dar formato a la fecha introducida, validada e incrementada

		public string FormatearFecha(int numero)
			{
			return "";
			}

		}
	}
