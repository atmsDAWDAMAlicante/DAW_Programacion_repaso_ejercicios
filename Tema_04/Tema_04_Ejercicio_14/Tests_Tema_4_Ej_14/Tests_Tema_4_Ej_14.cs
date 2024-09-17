using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_14_;

namespace Tests_Tema_4_Ej_14
	{
	[TestClass]
	public class Tests_Tema_4_Ej_14
		{
		[TestMethod]
		[DataRow(10500,10000, 1)]
		[DataRow(7000,5000, 1)]
		[DataRow(4000,2000, 2)]
		[DataRow(1000, 500, 2)]
		[DataRow(17, 5, 3)]
		[DataRow(1, 1, 1)]
		public void TestCambioUnidades(int cantidadTotal, int fraccion, int expected)
			{

			// Act
			Prog_Tema_4_Ej_14 objetoPrograma = new Prog_Tema_4_Ej_14();
			int actual = objetoPrograma.CalcularUnidades(ref cantidadTotal, fraccion);

			// Assert
			Assert.AreEqual(expected, actual);

			}
		}
	}
