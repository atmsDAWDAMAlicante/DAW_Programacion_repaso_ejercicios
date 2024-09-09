using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_10_;

namespace Tests_Tema_4_Ej_10
	{
	[TestClass]
	public class Tests_Tema_4_Ej_10
		{
		[TestMethod]
		[DataRow("1", true)]
		[DataRow("a", false)]
		public void TestMethodResultadoValidacion(string dato, bool expected)
			{
			// Act
			Prog_Tema_4_Ej_10 objetoPrograma = new Prog_Tema_4_Ej_10();
			bool actual = objetoPrograma.ValidarBase(dato);

			// Assert
			Assert.AreEqual(expected, actual);
			}


		}
	}
