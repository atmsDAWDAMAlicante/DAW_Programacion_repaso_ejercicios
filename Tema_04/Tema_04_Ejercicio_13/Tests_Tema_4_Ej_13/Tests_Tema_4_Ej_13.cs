using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_13_;
using System.Security.Cryptography;

namespace Tests_Tema_4_Ej_13
	{

	/*
	[TestClass]
	public class Tests_Tema_4_Ej_13
		{
		[TestMethod]
		public void TestMethod1()
			{
			}
		}

	*/


	[TestClass]
	public class Tests_Tema_4_Ej_13_Incrementar
		{
		[TestMethod]
		[DataRow(31, 1, false, 1)]
		[DataRow(30, 4, false, 1)]
		[DataRow(28, 2, false, 1)]
		[DataRow(29, 2, true, 1)]
		[DataRow(23, 2, false, 24)]
		[DataRow(14, 4, false, 15)]
		[DataRow(18, 7, false, 19)]
		[DataRow(6, 12, true, 7)]
		public void TestMethodSumarDias(int dia, int mes, bool bisiesto, int expected)
			{
			// Act
			Prog_Tema_4_Ej_13 objetoPrueba = new Prog_Tema_4_Ej_13();
			int actual = objetoPrueba.SumarDia(dia, mes, bisiesto);

			// Assert
			Assert.AreEqual(expected, actual);

			}

		[TestMethod]
		[DataRow(31, 1, false, 0)]
		public void TestMethodSumarMeses(int dia, int mes, bool bisiesto, int expected)
			{
			// Act
			Prog_Tema_4_Ej_13 objetoPrueba = new Prog_Tema_4_Ej_13();
			int actual = objetoPrueba.SumarMes(dia, mes, bisiesto);

			// Assert
			Assert.AreEqual(expected, actual);
			}



		[TestMethod]
		[DataRow(31, 1, 1980, 0)]
		public void TestMethodSumarAnos(int dia, int mes, int year, int expected)
			{
			// Act
			Prog_Tema_4_Ej_13 objetoPrueba = new Prog_Tema_4_Ej_13();
			int actual = objetoPrueba.SumarYear(dia, mes, year);

			// Assert
			Assert.AreEqual(expected, actual);
			}


		}




	[TestClass]
	public class Tests_Tema_4_Ej_13_Anos_Bisiestos
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
			Prog_Tema_4_Ej_13 objetoPrueba = new Prog_Tema_4_Ej_13();
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
			Prog_Tema_4_Ej_13 objetoPrueba = new Prog_Tema_4_Ej_13();
			bool actual = objetoPrueba.EsBisiesto(year);

			// Assert
			Assert.IsFalse(actual);
			}

		}



		[TestClass]
		public class Tests_Tema_4_Ej_13_Fechas
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
				Prog_Tema_4_Ej_13 objetoPrograma = new Prog_Tema_4_Ej_13();
				bool actual = objetoPrograma.ValidarFechaIntroducida(dia, mes, bisiesto);	

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
				Prog_Tema_4_Ej_13 objetoPrograma = new Prog_Tema_4_Ej_13();
				bool actual = objetoPrograma.ValidarFechaIntroducida(dia, mes, bisiesto);

				// Assert
				Assert.IsFalse(actual);
				}
			}
	}







