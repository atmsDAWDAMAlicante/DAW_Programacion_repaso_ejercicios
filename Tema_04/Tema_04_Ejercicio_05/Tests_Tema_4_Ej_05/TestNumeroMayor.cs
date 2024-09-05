using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prog_Tema_4_Ej_05_;
using System.Windows.Forms;

namespace Tests_Tema_4_Ej_05
	{
	[TestClass]
	public class TestNumeroMayor
		{
		[TestMethod]
		[DataRow("1", "2", "2")]
		[DataRow("-53", "-42", "-42")]
		public void TestMethodNumerosNormales(string num1, string num2, string expected)
			{
				// Act
				Prog_Tema_4_Ej_05 objetoProyecto = new Prog_Tema_4_Ej_05();
				string resultadoMetodo = objetoProyecto.Comparar(num1, num2);
				// Assert
				Assert.AreEqual(expected, resultadoMetodo);
			}
		[TestMethod]
		[DataRow("1", "1", "¡Dos iguales para hoy!")]
		[DataRow("-53", "-53", "¡Dos iguales para hoy!")]
		public void TestMethodNumerosIguales(string num1, string num2, string expected)
			{
			// Act
			Prog_Tema_4_Ej_05 objetoProyecto = new Prog_Tema_4_Ej_05();
			string resultadoMetodo = objetoProyecto.Comparar(num1, num2);
			// Assert
			Assert.AreEqual(expected, resultadoMetodo);
			}
		[TestMethod]
		[DataRow("a", "b", "Introduce números.")]
		[DataRow("a", "1", "Introduce números.")]
		[DataRow("-1", "b", "Introduce números.")]
		public void TestMethodLetras(string num1, string num2, string expected)
			{
			// Act
			Prog_Tema_4_Ej_05 objetoProyecto = new Prog_Tema_4_Ej_05();
			string resultadoMetodo = objetoProyecto.Comparar(num1, num2);
			// Assert
			Assert.AreEqual(expected, resultadoMetodo);
			}
		[TestMethod]
		[DataRow("2147483646", "2147483647", "2147483647")]
		[DataRow("2147483647", "2147483648", "Introduce números.")]
		[DataRow("-2147483648", "2147483647", "2147483647")]
		[DataRow("-21474836489", "2147483647", "Introduce números.")]
		public void TestMethodNumerosLimite(string num1, string num2, string expected)
			{
			// Act
			Prog_Tema_4_Ej_05 objetoProyecto = new Prog_Tema_4_Ej_05();
			string resultadoMetodo = objetoProyecto.Comparar(num1, num2);
			// Assert
			Assert.AreEqual(expected, resultadoMetodo);
			}
		}
	}
