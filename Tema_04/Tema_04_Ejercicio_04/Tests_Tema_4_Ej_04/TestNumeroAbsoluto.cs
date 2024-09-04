using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prog_Tema_4_Ej_04_;

namespace Tests_Tema_4_Ej_04
	{
	[TestClass]
	public class TestNumeroAbsoluto
		{
		[TestMethod]
		[DataRow("1", "1")]
		[DataRow("-2", "2")]
		// Valores límite
		[DataRow("2147483647", "2147483647")]
		[DataRow("-2147483647", "2147483647")]
		// Supuesto especial:  se produce un desbordamiento: no existe una representación positiva equivalente en un entero de 32 bits.
		[DataRow("-2147483648","-2147483648")]
		public void TestMethodPruebaNumerosDentroRango(string dato, string expected)
			{
			// Act
			Prog_Tema_4_Ej_04 pruebaDatoNormal = new Prog_Tema_4_Ej_04();
			string resultado = pruebaDatoNormal.Convertir(dato);

			// Assert
			Assert.AreEqual(resultado, expected);
			}
		[TestMethod]
		[DataRow("a")]
		// Valores fuera del rango de un entero
		[DataRow("2147483648")]
		[DataRow("-2147483649")]
		public void TestMethodPruebaNumerosFueraRangoyLetras(string dato)
			{
			// Act
			Prog_Tema_4_Ej_04 pruebaDatosErroneos = new Prog_Tema_4_Ej_04();
			string resultadoErroneo = pruebaDatosErroneos.Convertir(dato);

			// Assert
			Assert.AreEqual (resultadoErroneo, "Introduce números.");

			}
		}
	}
