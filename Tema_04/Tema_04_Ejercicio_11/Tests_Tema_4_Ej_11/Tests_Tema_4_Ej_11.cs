using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_11_;

namespace Tests_Tema_4_Ej_11
	{
	[TestClass]
	public class Tests_Tema_4_Ej_11
		{

		// Años SÍ Bisiestos
		[TestMethod]
		[DataRow(1812)]
		[DataRow(1936)]
		[DataRow(1940)]
		[DataRow(1952)]
		[DataRow(1968)]
		[DataRow(1976)]
		[DataRow(1984)]
		[DataRow(1992)]
		//[DataRow(2000)] el año 2000 fue un año especial... ya lo dijo Miguel Ríos ;)
		[DataRow(2020)]
		[DataRow(2024)]
		public void TestMethodAnosBisiestos(int year)
			{
			// Act
			Prog_Tema_4_Ej_11 objetoPrueba = new Prog_Tema_4_Ej_11();
			bool actual = objetoPrueba.EsBisiesto(year);

			// Assert
			Assert.IsTrue(actual);
			}

		// Años NO Bisiestos
		[TestMethod]
		[DataRow(1700)]
		[DataRow(1800)]
		[DataRow(1900)]
		[DataRow(2000)] // El año 2000 fue un año especial
		[DataRow(2100)]
		[DataRow(2200)]
		[DataRow(2300)]
		[DataRow(2500)]
		[DataRow(2600)]
		public void TestMethodAnosNoBisiestos(int year)
			{
			// Act
			Prog_Tema_4_Ej_11 objetoPrueba = new Prog_Tema_4_Ej_11();
			bool actual = objetoPrueba.EsBisiesto(year);

			// Assert
			Assert.IsFalse(actual);
			}




		}
	}
