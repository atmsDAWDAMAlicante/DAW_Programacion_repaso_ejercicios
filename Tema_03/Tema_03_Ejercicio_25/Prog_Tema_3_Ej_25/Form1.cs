using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_25
	{
	public partial class Prog_Tema_3_Ej_25 : Form
		{
		public Prog_Tema_3_Ej_25()
			{
			InitializeComponent();
			}

		private void btnMostrar_Click(object sender, EventArgs e)
			{
			lblResultado1.Text = "";
			lblResultado2.Text = "";
			lblResultado3.Text = "";
			lblResultado4.Text = "";
			lblResultado5.Text = "";
			int contador = 1;
			int contadorBucle = 0;
			string tablaEnCurso = "";
			while (contador < 11) 
			{ 
				// El bucle for escribe la tabla de multiplicar y la almacena en la variable 'tablaEnCurso'
				for (int i = 1; i < 11; i++)
					{
					tablaEnCurso += $"{contador} * {i} = {contador * i}\n";
					}
				tablaEnCurso += "\n"; // se añade un salto de línea a 'tablaEnCurso' para separar las tablas de multiplicar

				// Se incrementa la variable 'contadorBucle' para saber en qué tabla de multiplicar estamos y así
				// cambiar el label de salida: cada dos tablas completas, se mueve al label de la derecha
				contadorBucle++;

				// Estos bloques condicionales evalúan el valor de 'contadorBucle' y señalan el label de salida
				if ((contador > 0) && (contador <= 2))
					{
					lblResultado1.Text += tablaEnCurso;
					}
				else if ((contador > 2) && (contador <= 4))
					{
					lblResultado2.Text += tablaEnCurso;
					}
				else if ((contador > 4) && (contador <= 6))
					{
					lblResultado3.Text += tablaEnCurso;
					}
				else if ((contador > 6) && (contador <= 8))
					{
					lblResultado4.Text += tablaEnCurso;
					}
				else
					{
					lblResultado5.Text += tablaEnCurso;
					}

				// Se borra el contenido de la variable 'tablaEnCurso' para que la vuelva a rellenar el bucle for
				// con el nuevo valor de 'contador' que se incrementa en la línea siguiente
				tablaEnCurso = "";
				contador++; // Se repetirá todo hasta que 'contador' alcance el valor de 11
			}

			

			}
			
		}
	}
