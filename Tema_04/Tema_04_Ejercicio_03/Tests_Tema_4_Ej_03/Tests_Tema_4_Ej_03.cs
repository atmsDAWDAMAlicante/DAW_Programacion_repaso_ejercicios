using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prog_Tema_4_Ej_03_;
using System.Windows.Forms;


namespace Tests_Tema_4_Ej_03
	{
	[TestClass]
	public class Tests_Tema_4_Ej_03
		{

		// Se diseñan dos pruebas unitarias, a las que se les pasarán los parámetros mediante el decorador DataRow

		// Este primer método sólo recibe pasa dos enteros que pasa a la función Intercambiar() y el string que recoge el resultado es el 
		// que se compara con la cadena (formada con plantillas literales).
		[TestMethod]
		[DataRow(2, 3)]
		[DataRow(1, 2)]
		public void TestMethodDevuelveStringVariablesIntercambiadas(int x, int y)
			{
			// Act 

			Prog_Tema_4_Ej_03 intercambioValores = new Prog_Tema_4_Ej_03();
			string resultadoTest = intercambioValores.Intercambiar(x, y);

			// Assert
			Assert.AreEqual($"Antes: x = {x}, y = {y}\nAhora: x = {y}, y = {x}", resultadoTest);
			}


		// Este segundo método recibe dos enteros y un string que se comparará con el string resultante de la llamada a la
		// función Intercambiar a la que se le pasan esos dos enteros.
		[TestMethod]
		[DataRow(4, 5, "Antes: x = 4, y = 5\nAhora: x = 5, y = 4")]
		public void TestMethodSePruebaUnStringRedactado(int x, int y, string stringRedactado)
			{
			// Act
			Prog_Tema_4_Ej_03 intercambioValores = new Prog_Tema_4_Ej_03();
			string resultadoTest = intercambioValores.Intercambiar(x, y);

			// Assert
			Assert.AreEqual(stringRedactado, resultadoTest);
			}



		}
	}
