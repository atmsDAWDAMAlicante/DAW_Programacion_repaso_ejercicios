using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_07_;

namespace Tests_Tema_4_Ej_07
	{
	[TestClass]
	public class Tests_Tema_4_Ej_07
		{
		[TestMethod]
		[DataRow(1,2,1)]
		[DataRow(45785225, 25, 25)]
		[DataRow(5,1245,5)]
		[DataRow(-586, -2, 2)] // En la llamada al método IdentificarMenor() se enviarán los valores absolutos para controlar los números negativos
		[DataRow(2, 2, 2)]
		[DataRow(0, 1, 1)] // Supuesto en que se introduce un 0 en un TextBox; el método devuelve MCD = 1
		[DataRow(0, 0, 1)] // Supuesto en que se introducen dos 0 en los TextBox; el método devuelve MCD = 1
		public void TestMethodMaximoComunDivisor(int num1, int num2, int expected)
			{

			//Act
			Prog_Tema_4_Ej_07 objetoMCD = new Prog_Tema_4_Ej_07();
			// El método IdentificarMenor() identifica qué número es mayor que otro para enviarlos en el orden correcto a la función
			// Calcular() que devuelve a la función IdentificarMenor() el Máximo Común Divisor
			// La comprobación previa que hace la función IdentificarMenor() permite identificar el punto de partida del bucle
			// del método Calcular(). En el momento de la llamada al método IdentificarMenor() no importa el orden de los parámetros
			int resultado = objetoMCD.IdentificarMenor(Math.Abs(num1), Math.Abs(num2)); // Se envían los valores absolutos

			// Assert
			Assert.AreEqual(expected, resultado);
			}
		}
	}
