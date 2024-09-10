using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_12_;

namespace Tests_Tema_4_Ej_12
	{
	[TestClass]
	public class Tests_Tema_4_Ej_12_Fechas
		{
		[TestMethod]
		[DataRow(31,1,false)]
		[DataRow(28,2,false)]
		[DataRow(29,2,true)]
		[DataRow(31,3,false)]
		[DataRow(30,4,false)]
		[DataRow(31,5,false)]
		[DataRow(30,6,false)]
		[DataRow(31,7,false)]
		[DataRow(31,8,false)]
		[DataRow(30,9,false)]
		[DataRow(31,10,false)]
		[DataRow(30,11,false)]
		[DataRow(31,12,false)]
		public void TestMethodFechaCorrecta(int dia, int mes, bool bisiesto)
			{
			// Act
			Prog_Tema_4_Ej_12 objetoPrograma = new Prog_Tema_4_Ej_12();
			bool actual = objetoPrograma.VerificarFecha(dia, mes, bisiesto);	

			// Assert
			Assert.IsTrue(actual);
			}

		[TestMethod]
		[DataRow(32, 1, false)]
		[DataRow(29, 2, false)]
		[DataRow(30, 2, true)]
		[DataRow(31, 4, false)]
		[DataRow(-2, 5, false)]
		[DataRow(31, 6, false)]
		[DataRow(31, 9, false)]
		[DataRow(31, 11, false)]
		public void TestMethodFechaInorrecta(int dia, int mes, bool bisiesto)
			{
			// Act
			Prog_Tema_4_Ej_12 objetoPrograma = new Prog_Tema_4_Ej_12();
			bool actual = objetoPrograma.VerificarFecha(dia, mes, bisiesto);

			// Assert
			Assert.IsFalse(actual);
			}


		}


		[TestClass]
		public class Tests_Tema_4_Ej_12_Anos_Bisiestos
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
				Prog_Tema_4_Ej_12 objetoPrueba = new Prog_Tema_4_Ej_12();
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
				Prog_Tema_4_Ej_12 objetoPrueba = new Prog_Tema_4_Ej_12();
				bool actual = objetoPrueba.EsBisiesto(year);

				// Assert
				Assert.IsFalse(actual);
				}

		}


	}
