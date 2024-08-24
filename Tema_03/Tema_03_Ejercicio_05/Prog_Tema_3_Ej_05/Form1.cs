using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_05
{
    public partial class Prog_Tema_3_Ej_05 : Form
    {
        public Prog_Tema_3_Ej_05()
        {
            InitializeComponent();
        }


        private void btnAccion_Click(object sender, EventArgs e)
        {
			// int.TryParse evalúa para cada TextBox si lo introducido es un número
			// Si lo es lo convierte en un entero
			// Las variables num1esnum, num2esnum y num3esnum recogen un valor booleano en función de si tiene éxito la conversión a entero
			// No se utiliza try-catch	
			bool num1esnum = int.TryParse(txtNumero1.Text, out int numero1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int numero2);
            bool num3esnum = int.TryParse(txtNumero3.Text, out int numero3);

            // Declaración e inicialización de tres variables string que imprimirán el resultado tras la comparación de los números
            string posibilidad1 = "", posibilidad2 = "", posibilidad3 = "";

			// Bloque condicional if que evalúa si ha tenido éxito la conversión a entero de lo introducido en los TextBox
			if (num1esnum && num2esnum && num3esnum)
            {

				// Primera parte: es la que pide el enunciado del ejercicio: indicar cuál de los tres números es el mayor
				// Se divide en tres bloques separados por comentarios para leerlo con mayor claridad
				// pero todo está dentro de un gran bloque if con diversos else if encadenados de forma que se evalúan todas las posibilidades
				// menos una que se deja a la claúsula else

				// 1ª Evaluación: todos los números son diferentes
				if ((numero1 > numero2) && (numero1 > numero3))
					{
					lblResultado1.Text = $"Número 1 ({numero1}) es mayor que Número 2 ({numero2}) y Número 3 ({numero3})";
					}
				else if ((numero2 > numero1) && (numero2 > numero3))
					{
					lblResultado1.Text = $"Número 2 ({numero2}) es mayor que Número 1 ({numero1}) y Número 3 ({numero3})";
					}
				else if ((numero3 > numero1) && (numero3 > numero2))
					{
					lblResultado1.Text = $"Número 3 ({numero3}) es mayor que Número 1 ({numero1}) y Número 2 ({numero2})";
					}

				// 2ª Evaluación: dos números iguales y mayores que el tercero
				else if ((numero1 == numero2) && (numero1 > numero3))
					{
					lblResultado1.Text = $"Los números Número 1 ({numero1}) y Número 2 ({numero2}) son iguales\ny mayores que el Número 3 ({numero3}) ";
					}
				else if ((numero1 == numero3) && (numero1 > numero2))
					{
					lblResultado1.Text = $"Los números Número 1 ({numero1}) y Número 3 ({numero3}) son iguales\ny mayores que el Número 2 ({numero2}) ";
					}
				else if ((numero2 == numero3) && (numero2 > numero1))
					{
					lblResultado1.Text = $"Los números Número 2 ({numero2}) y Número 3 ({numero3}) son iguales\ny mayores que el Número 1 ({numero1}) ";
					}

				// 3ª Evaluación: os números iguales y menores que el tercero
				else if ((numero1 == numero2) && (numero1 < numero3))
					{
					lblResultado1.Text = $"Los números Número 1 ({numero1}) y Número 2 ({numero2}) son iguales\ny menores que el Número 3 ({numero3}) ";
					}
				else if ((numero1 == numero3) && (numero1 < numero2))
					{
					lblResultado1.Text = $"Los números Número 1 ({numero1}) y Número 3 ({numero3}) son iguales\ny menores que el Número 2 ({numero2}) ";
					}
				else if ((numero2 == numero3) && (numero3 < numero1))
					{
					lblResultado1.Text = $"Los números Número 2 ({numero2}) y Número 3 ({numero3}) son iguales\ny menores que el Número 1 ({numero1}) ";
					}


				// La última alternativa: que sean iguales los tres números
				else
					{
					lblResultado1.Text = $"Los números Número 1 ({numero1}), Número 2 ({numero2})\ny Número 3 ({numero3}) son iguales";
					}



				// Segunda parte: añadido al ejercicio. El programa detalla la comparación entre números.

				// Se evalúa la relación entre los números en tres bloques if
				// En cada bloque se comparan los números por parejas; en función del resultado el string toma un valor u otro ("igual", "menor", "mayor")

				// Relación entre numero1 y numero2
				if (numero1 == numero2)
					{
						posibilidad1 = "igual";
					} 
					else if (numero1 < numero2)
					{
						posibilidad1 = "menor";
					}
					else if (numero1 > numero2)
					{
						posibilidad1 = "mayor";
					}

					// Relación entre numero1 y numero3
					if (numero1 == numero3)
					{
						posibilidad2 = "igual";
					}
					else if (numero1 < numero3)
					{
						posibilidad2 = "menor";
					}
					else if (numero1 > numero3)
					{
						posibilidad2 = "mayor";
					}

					// Relación entre numero2 y numero3
					if (numero2 == numero3)
					{
						posibilidad3 = "igual";
					}
					else if (numero2 < numero3)
					{
						posibilidad3 = "menor";
					}
					else if (numero2 > numero3)
					{
						posibilidad3 = "mayor";
					}

				lblResultado2.Text = $"El Número 1 ({numero1}) es {posibilidad1} que el Número 2 ({numero2})\n" +
				$"El Número 1 ({numero1}) es {posibilidad2} que el Número 3 ({numero3})\n" +
				$"El Número 2 ({numero2}) es {posibilidad3} que el Número 3 ({numero3})";
				}

			else
            {
                lblResultado2.Text = "Introduce números";
            }





        }

    }
}
