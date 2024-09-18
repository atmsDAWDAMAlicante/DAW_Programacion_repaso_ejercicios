using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_15_;

namespace Tests_Tema_4_Ej_15
	{
	[TestClass]
	public class Tests_Tema_4_Ej_15
		{
		[TestMethod]
		[DataRow(5000,500,10)]
		[DataRow(6, 2, 3)]
		[DataRow(1, 1, 1)]
		public void TestMethodCambioImporteEuros(double importe, double fraccion, int expected)
			{

			// Act
			Prog_Tema_4_Ej_15 objetoPrograma = new Prog_Tema_4_Ej_15();
			int actual = objetoPrograma.CalcularUnidades(ref importe, fraccion);
			// Assert
			Assert.AreEqual(expected, actual);
			}

		[TestMethod]
		[DataRow(70, 50, 1)]
		[DataRow(23, 10, 2)]
		[DataRow(1, 1, 1)]
		[DataRow(3, 2, 1)]
		public void TestMethodCambioImporteCentimos(double importe, double fraccion, int expected)
			{

			// Act
			Prog_Tema_4_Ej_15 objetoPrograma = new Prog_Tema_4_Ej_15();
			int actual = objetoPrograma.CalcularCentimos(ref importe, fraccion);
			// Assert
			Assert.AreEqual(expected, actual);
			}




		}
	}
