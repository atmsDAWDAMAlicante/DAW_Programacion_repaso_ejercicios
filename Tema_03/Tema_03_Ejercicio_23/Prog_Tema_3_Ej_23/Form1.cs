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

namespace Prog_Tema_3_Ej_23
	{
	public partial class Prog_Tema_3_Ej_23 : Form
		{
		public Prog_Tema_3_Ej_23()
			{
			InitializeComponent();
			}

		private void btnAccion_Click(object sender, EventArgs e)
			{
			// Se declaran las siguientes variables entero y double y se inicializan todas a 0
			// Variable peso que es la que recogerá los pesos que se introduzcan mediante el InputBox
			double peso;

			// Variables que recogen los números de los alumnos por grupo. De tipo entero
			int numAlumnosMenos50 = 0;
			int numAlumnos50a65 = 0;
			int numAlumnos65a80 = 0;
			int numAlumnosMas80 = 0;
			int numAlumnosTotal = 0; // la variable total que recogerá la suma de las anteriores

			// Variables que recogen los pesos de los alumnos por grupo. De tipo double
			double pesoAlumnosMenos50 = 0;
			double pesoAlumnos50a65 = 0;
			double pesoAlumnos65a80 = 0;
			double pesoAlumnosMas80 = 0;
			double pesoAlumnosTotal = 0; // la variable total que recogerá la suma de las anteriores

			lblAlerta.Text = "";
			lblResultado.Text = "";


			// Bucle Do...While que se repetirá hasta que se introduzca un número negativo en el InputBox
			// Al tratarse de un bucle Do...While se ejecutará por lo menos una vez
			do {
				bool numEsNum = double.TryParse(Interaction.InputBox("Introduce un peso"), out peso);
				if (numEsNum) // Cada vez que se introduzca un valor no válido se reiniciará el recuento de pesos/alumnos
					{ // (<=50), (>50 y <=65), (>65 y <=80), (>80)
					if ((peso > 0) && (peso <= 50))
						{
						pesoAlumnosMenos50 += peso; // si el peso introducido pertenece al rango, se acumula al total de pesos de esta categoría
						numAlumnosMenos50++; // se incrementa el número de alumnos de este rango
						lblAlerta.Text = "";
						}
					else if ((peso > 50) && (peso <= 65))
						{
						pesoAlumnos50a65 += peso; // si el peso introducido pertenece al rango, se acumula al total de pesos de esta categoría
						numAlumnos50a65++; // se incrementa el número de alumnos de este rango
						lblAlerta.Text = "";
						}
					else if ((peso > 65) && (peso <= 80))
						{
						pesoAlumnos65a80 += peso; // si el peso introducido pertenece al rango, se acumula al total de pesos de esta categoría
						numAlumnos65a80++; // se incrementa el número de alumnos de este rango
						lblAlerta.Text = "";
						}
					else if (peso > 80)
						{
						pesoAlumnosMas80 += peso; // si el peso introducido pertenece al rango, se acumula al total de pesos de esta categoría
						numAlumnosMas80++; // se incrementa el número de alumnos de este rango
						lblAlerta.Text = "";
						}
					}
				else
					{
					lblAlerta.Text = "Introduce números";
					}


				} while (peso > 0);

			// Introducido un número negativo en el InputBox se sale del bucle Do...While
			// Se suman todos los números de los distintos grupos de alumnos
			numAlumnosTotal = numAlumnosMenos50 + numAlumnos50a65 + numAlumnos65a80 + numAlumnosMas80;
			// Se suman todos los pesos de los distintos grupos de alumnos
			pesoAlumnosTotal = pesoAlumnosMenos50 + pesoAlumnos50a65 + pesoAlumnos65a80 + pesoAlumnosMas80;

			// Se actualiza el label que muestra el resultado mediante plantillas literales
			// Para cada grupo de alumnos se muestra su total y el promedio que representa sobre el total de alumnos
			// se utiliza una fórmula del % ((numero total de cada grupo * 100)/ numero total de alumnos de toda el aula).
			// A efectos de un redondeo del resultado, se han utilizado enteros en las variables relativas a los números de alumnos
			lblResultado.Text = $"Totales:\n{numAlumnosMenos50} alumnos con un peso inferior a 50 kg ({(numAlumnosMenos50*100)/numAlumnosTotal}%)\n" +
				$"{numAlumnos50a65} alumnos con un peso entre 51 y 65 kg ({(numAlumnos50a65*100) / numAlumnosTotal}%)\n" +
				$"{numAlumnos65a80} alumnos con un peso entre 66 y 80 kg ({(numAlumnos65a80*100) / numAlumnosTotal}%)\n" +
				$"{numAlumnosMas80} alumnos con un peso superior a 80 kg ({(numAlumnosMas80*100) / numAlumnosTotal}%)\n" +
				$"Total de alumnos: {numAlumnosTotal} alumnos\n" +
				$"Media del peso del aula: {pesoAlumnosTotal/numAlumnosTotal} kg";
			}
		}
	}
