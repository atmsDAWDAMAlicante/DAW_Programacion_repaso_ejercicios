using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_06_;

namespace Tests_Tema_4_Ej_06
	{
	// Creo dos clases para probar por separado la división y el resto
	// Delante de la declaración de cada clase hay que poner el decorador [TestClass] para que Visual Studio lleve a cabo la prueba

	// La llamada al método CalcularDivision o CalcularResto tiene tres parámetros, uno de ellos out, por lo tanto hay que 
	// introducir ese tercer parámetro en la llamada al método aunque no sea relevante en el método Assert

	[TestClass]
	public class TestDivision
		{
		[TestMethod]
		[DataRow(5, 3, "El resultado de la\ndivisión entera es:")]
		[DataRow(16, 20, "El resultado de la\ndivisión entera es:")]
		public void TestMethodDivisionNumerosCorrectos(int a, int b, string expected)
			{
			// Arrange
			int resultado;
			// Act
			Prog_Tema_4_Ej_06 objetoPrueba = new Prog_Tema_4_Ej_06();
			string actual = objetoPrueba.CalcularDivision(a, b, out resultado);
			// Assert
			Assert.AreEqual(expected, actual);

			}
		[TestMethod]
		[DataRow(4,0, "Error:\ndivisión por ")]
		public void TestMethodDivisionPorCero(int a, int b, string expected)
			{
			// Arrange
			int resultado;
			// Act
			Prog_Tema_4_Ej_06 objetoPrueba = new Prog_Tema_4_Ej_06();
			string actual = objetoPrueba.CalcularDivision(a, b, out resultado);
			// Assert
			Assert.AreEqual(expected, actual);
			}
		}

	[TestClass]
	public class TestResto
		{

		[TestMethod]
		[DataRow(5,3, "El resto es:")]
		[DataRow(16, 20, "El resto es:")]
		public void TestMethodRestoDivisionNumerosCorrectos(int a, int b, string expected)
			{
			// Arrange
			int resultado;
			// Act
			Prog_Tema_4_Ej_06 objetoPrueba = new Prog_Tema_4_Ej_06();
			string actual = objetoPrueba.CalcularResto(a, b, out resultado);
			// Assert
			Assert.AreEqual(expected, actual);
			}
		[TestMethod]
		[DataRow(4, 0, "Error:\ndivisión por ")]
		public void TestMethodRestoDivisionPorCero(int a, int b, string expected)
			{
			// Arrange
			int resultado;
			// Act
			Prog_Tema_4_Ej_06 objetoPrueba = new Prog_Tema_4_Ej_06();
			string actual = objetoPrueba.CalcularResto(a, b, out resultado);
			// Assert
			Assert.AreEqual(expected, actual);
			}
		}



	}
