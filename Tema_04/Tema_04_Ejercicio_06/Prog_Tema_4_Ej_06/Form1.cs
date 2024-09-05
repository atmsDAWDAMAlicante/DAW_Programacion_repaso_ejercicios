using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_06_
{
    public partial class Prog_Tema_4_Ej_06 : Form
    {
        public Prog_Tema_4_Ej_06()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
			lblResultadoDivision.Text = "";
			lblResultadoResto.Text = "";

			// Ejercicio las variables tipo entero que recogen los resultados de las operaciones se pasan por referencia out

            // El código pega muchas vueltas para practicar y que encaje el paso de parámetros por referencia y las pruebas unitarias 

			bool num1esnum = int.TryParse(txtNumero1.Text, out int numero1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int numero2);

            if (num1esnum && num2esnum)
            {
                // Se declaran dos variables entero que serán pasadas a los métodos por referencia out
                // Cambiará su valor en los métodos y será impreso en los label correspondientes
                int division, resto = 1;

                // Se declaran e inicializan dos variables tipo string que recogerán el resultado de las funciones
                // y que se imprimirán en los label correspondientes
				string resultadoDivision = CalcularDivision(numero1, numero2, out division);
				string resultadoResto = CalcularResto(numero1, numero2, out resto);

                // Impresión del resultado de la división
                lblTituloDivision.Text = resultadoDivision;
                lblResultadoDivision.Text = $"{division}";

				// Impresión del resultado del módulo
				lblTituloResto.Text = resultadoResto;
				lblResultadoResto.Text = $"{resto}";
				}
            else
            {
                lblTituloDivision.Text = "Introduce números.";
				lblTituloResto.Text = "Introduce números.";
				}
        }

        public string CalcularDivision(int numero1, int numero2, out int division)
        {
            if (numero2 != 0) // Si no es una división por cero devolverá un mensaje y el entero tomará el valor del resultado de la operación
				{
                division = numero1 / numero2;
				return "El resultado de la\ndivisión entera es:";
				}
			else // Si es una división por cero devolverá un mensaje de error y el entero tomará el valor de 0
				{
                division = 0;
                return "Error:\ndivisión por ";
                }
			}

        public string CalcularResto(int numero1, int numero2, out int resto)
            {

			if (numero2 != 0) // Si no es una división por cero devolverá un mensaje y el entero tomará el valor del resultado de la operación
				{
				resto = numero1 % numero2;
				return "El resto es:";
				}
			else // Si es una división por cero devolverá un mensaje de error y el entero tomará el valor de 0
				{
				resto = 0;
				return "Error:\ndivisión por ";
				}
			}


    }
}
