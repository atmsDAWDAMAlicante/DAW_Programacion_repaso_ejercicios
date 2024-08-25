using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_11
	{
	public partial class Prog_Tema_3_Ej_11 : Form
		{
		public Prog_Tema_3_Ej_11()
			{
			InitializeComponent();
			txtHoras.Text = "23";
			txtMinutos.Text = "59";
			txtSegundos.Text = "59";
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			// Con estos métodos se evalúa si lo introducido son números y los convierte en enteros; y si no lo es, la variable booleana
			// devuelve false, por lo que se imprimirá un string indicando "Introduce números."
			// Estas funciones declaran las variables horas, minutos y segundos
			// No se utiliza try-catch


			bool horasesnum = int.TryParse(txtHoras.Text, out int horas);
			bool minutosesnum = int.TryParse(txtMinutos.Text, out int minutos);
			bool segundosesnum = int.TryParse(txtSegundos.Text, out int segundos);

			lblResultado.Text = "";

			// A) Evaluación si se han introducido valores numéricos
			if (!(horasesnum && minutosesnum && segundosesnum)) // Bloque if del punto A)
				{
				lblResultado.Text = "Introduce números.";
				}
			// B) Evaluación si se han introducido minutos y segundos en rango (0-59)
			else if (!((minutos >= 0) && (minutos <= 59) && (segundos >= 0) && (segundos <= 59))) // Bloque if del punto B)
				{
				lblResultado.Text = "Introduce minutos\ny/o segundos\nentre 0 y 59";
				}

			// C) Evaluación si se han introducido en rango (0-23)
			else if (!((horas >= 0) && (horas <= 23))) // Bloque if del punto C)
				{
				lblResultado.Text = "Introduce horas\nentre 0 y 23";
				}



			else // Bloque else donde se harán las evaluaciones de los datos correctos comenzando por los segundos
				 // En el bloque condicional de los segundos, si éstos valen 59, entonces tomarán el valor 0
				 // En el bloque condicional de los minutos, si las horas valen 59 y los segundos 0, entonces 'minutos' tomará el valor 0
				 // En el bloque condicional de las horas, si las horas valen 23 y los minutos 0, entonces 'horas' tomará el valor 0
				{
				// 1º Actualización de los segundos
				if ((segundos >= 0) && (segundos <= 58))
					{
					segundos++;
					}
				else
					{
					segundos = 0;
					}

				// 2º Actualización de los minutos
				if ((minutos >= 0) && (minutos <= 58) && (segundos == 0))
					{
					minutos++;
					}
				else if ((minutos == 59) && (segundos == 0))
					{
					minutos = 0;
					}

				// 3º Actualización de los minutos
				if ((horas >= 0) && (horas <= 22) && (minutos == 0))
					{
					horas++;
					}
				else if ((horas == 23) && (minutos == 0))
					{
					horas = 0;
					}

				// Bloque if para formatear el resultado
				string ceroHoras = "";
				string ceroMinutos = "";
				string ceroSegundos = "";

				if ((horas >= 0) && (horas<=9))
						ceroHoras = "0";
				if ((minutos >= 0) && (minutos <= 9))
					ceroMinutos = "0";
				if ((segundos >= 0) && (segundos <= 9))
					ceroSegundos = "0";

				lblResultado.Text = $"{ceroHoras}{horas}:{ceroMinutos}{minutos}:{ceroSegundos}{segundos}";


				} // Fin del bloque else que de los bloques if+else if que comprueban los datos introducidos

			}
		}
	}
