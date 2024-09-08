using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using Prog_Tema_4_Ej_09_;

namespace Tests_Tema_4_Ej_09
	{
	[TestClass]
	public class Tests_Tema_4_Ej_09
		{
		[TestMethod]
		[DataRow(2,4,16)]
		[DataRow(3,3,27)]
		public void TestMethodPotenciaCorrecta(double baseNum, double exponenteNum, double expected)
			{
			// Act
			Prog_Tema_4_Ej_09 objetoPrueba = new Prog_Tema_4_Ej_09();
			double resultado = objetoPrueba.EjecutarPotencia(baseNum, exponenteNum);

			// Assert
			Assert.AreEqual(expected, resultado);
			}

		// La idea era que una función al calcuar la potencia 'EjecutarPotencia()' capturara la excepción con 'ArgumentOutOfRangeException'
		// pero Math.Pow no captura esa excepción, por eso nunca se ejecutará el bloque catch
		/*
		[TestMethod]
		public void TestMethodExcepcionFueraDeRango()
			{
			// Act
			Prog_Tema_4_Ej_09 objetoPrueba = new Prog_Tema_4_Ej_09();
			}
		*/

		}


	}
