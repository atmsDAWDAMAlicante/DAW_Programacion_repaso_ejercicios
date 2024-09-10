using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_12_
	{
	public partial class Prog_Tema_4_Ej_12 : Form
		{
		public Prog_Tema_4_Ej_12()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "";
			bool diaEsNum = int.TryParse(txtDia.Text, out int diaNum);
			bool mesEsNum = int.TryParse(txtMes.Text, out int mesNum);
			bool yearEsNum = int.TryParse(txtYear.Text, out int yearNum);
			bool fechaValidacion, bisiesto;

			// Primero, se evalúa si lo introducido en los TextBox son números
			if (diaEsNum && mesEsNum && yearEsNum) 
				{
				// Segundo, se evalúa si el número correspondiente al año tiene cuatro dígitos
				if ((yearNum.ToString().Length == 4))
					{
					// Tercero, se evalúa si el año es bisiesto llamando a la función 'EsBisiesto' y pasándole el
					// valor de la variable que almacena el año. El resultado lo recoge una variable booleana
					bisiesto = EsBisiesto(yearNum);
					// En cuarto lugar, se valida la fecha enviando, los tres enteros que componen la fecha, a
					// una función VerificarFecha() que devuelve un valor booleano que se recoge en 'fechaValidacion'
					fechaValidacion = VerificarFecha(diaNum, mesNum, bisiesto);
					// Si 'fechaValidacion' es true, se envía el entero diaNum a la función ComponerFecha() para que le
					// agregue un '0' delante si el número es inferior a 10; y, a continuación, se hace lo mismo con el 
					// valor de mesNum, para finalmente obtener una fecha del tipo '03/09/1977' o '02/04/2016'
					if (fechaValidacion)
						{
						lblResultado.Text = $"{ComponerFecha(diaNum.ToString())}/{ComponerFecha(mesNum.ToString())}/{yearNum}";
						}
					else
						{
						lblResultado.Text = "La fecha no es válida";
						}
					}
				else
					{
					lblResultado.Text = "Introduce un año\ncon 4 dígitos";
					}
				}

			else
				{
				lblResultado.Text = "Introduce números.";
				}
			}

		public bool EsBisiesto (int year)
			{
			if ( (year%4==0) && (!(year%100==0)) && (year%400!=0) )
				{
				return true;
				}
			else
				{
				return false;
				}
			}

		public bool VerificarFecha(int dia, int mes, bool bisiesto)
			{
			if (((mes == 1) || (mes == 3) || (mes == 5) || (mes == 7) || (mes == 8) || (mes == 10) || (mes==12)) && ((dia > 0) && (dia <32)))
				{
				return true;
				}
			else if ( ( (mes == 4) || (mes == 6) || (mes == 9) || (mes == 11) ) && ( (dia > 0) && (dia < 31) ))
				{
				return true;
				}
			else if ((mes == 2) && (bisiesto == false) && ((dia > 0) && (dia < 29)))
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

		public string ComponerFecha(string diaOmes)
			{
			if (diaOmes.Length < 2)
				{
				return $"0{diaOmes}";
				}
			else
				{
				return $"{diaOmes}";
				}
			}
		}
	}
