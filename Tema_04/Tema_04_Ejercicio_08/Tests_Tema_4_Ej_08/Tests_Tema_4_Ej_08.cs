using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_08_;

namespace Tests_Tema_4_Ej_08
	{
	[TestClass]
	public class Tests_Tema_4_Ej_08
		{
		[TestMethod]
		// El valor esperado debe corresponderse con el formato adecuado de número con decimales que se devuelve como string y formatea con F2
		[DataRow("5", "5", "5", "5,00")]
		[DataRow("3", "5", "8", "5,33")]
		[DataRow("7", "9", "4", "6,67")]
		public void TestMethodNumerosCorrectos(string num1, string num2, string num3, string expected)
			{
			// Act
			Prog_Tema_4_Ej_08 objetoPrueba = new Prog_Tema_4_Ej_08();
			string resultado = objetoPrueba.ValidarCampos(num1, num2, num3);
			// Assert
			Assert.AreEqual(expected, resultado);
			}

		[TestMethod]
		[DataRow("-1", "2", "7", "Introduce un valor\nentre 0 y 10")]
		[DataRow("5", "100", "6", "Introduce un valor\nentre 0 y 10")]
		[DataRow("a", "7", "/", "Introduce números.")]
		public void TestMethodNumerosIncorrectos(string num1, string num2, string num3, string expected)
			{
			// Act
			Prog_Tema_4_Ej_08 objetoPrueba = new Prog_Tema_4_Ej_08();
			string resultado = objetoPrueba.ValidarCampos(num1, num2, num3);
			// Assert
			Assert.AreEqual(expected, resultado);
			}


		}
	}
