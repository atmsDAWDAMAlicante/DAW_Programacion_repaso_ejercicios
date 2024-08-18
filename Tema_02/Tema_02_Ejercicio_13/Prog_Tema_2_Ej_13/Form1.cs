using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_2_Ej_13
	{
	public partial class Prog_Tema_2_Ej_13 : Form
		{
		public Prog_Tema_2_Ej_13()
			{
			InitializeComponent();
			}

		private void btnCalcular_Click(object sender, EventArgs e)
			{
			lblResultado.Text = "Resultado:\n";
			const double retencion = 18;
			try
				{
				// Declaracióin, inicialización y conversión de los datos que se recogen de los TextBox
				double importeHoraTrabajada = double.Parse(txtImporteHoraTrabajada.Text);
				double horasNormales = double.Parse(txtHorasNormales.Text);
				double horasExtra = double.Parse(txtHorasExtra.Text);

				// Declaración, inicialización y conversión de las variables que recogen los resultados de las operaciones
				double totalHorasNormales = importeHoraTrabajada * horasNormales;
				double totalHorasExtra = ((importeHoraTrabajada * 2) * horasExtra);
				double subtotal = totalHorasNormales + totalHorasExtra;
				double totalRetencion = (subtotal * (retencion / 100));
				double total = subtotal - totalRetencion;

				// Impresión por pantalla del resultado
				lblResultado.Text += $"Se han trabajado un total de {horasNormales+horasExtra} horas\n" +
					$"con el siguiente importe a percibir:\n" +
					$"- {horasNormales} horas normales trabajadas a {importeHoraTrabajada} € la hora:\n" +
					$"Total horas normales: {totalHorasNormales} €\n" +
					$"- {horasExtra} horas extra trabajadas a {importeHoraTrabajada*2} € la hora\n" +
					$"Total horas extra: {totalHorasExtra} €\n" +
					$"Subtotal: {subtotal} €\n" +
					$"{retencion}% de retención: {totalRetencion} €\n" +
					$"TOTAL A PERCIBIR: {total} €";

				}
			catch (FormatException) 
				{
				MessageBox.Show("Introduzca números");
				}
			}
		}
	}
