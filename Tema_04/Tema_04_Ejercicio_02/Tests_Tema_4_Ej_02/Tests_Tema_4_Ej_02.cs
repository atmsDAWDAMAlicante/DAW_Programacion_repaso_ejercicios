using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prog_Tema_4_Ej_02_;

namespace Tests_Tema_4_Ej_02
	{
	[TestClass]
	public class Tests_Tema_4_Ej_02
		{
		// Con DataRow se pueden pasar valores por parámetro al método Test y se pueden añadir tantas DataRow que se deseen
		[DataRow(45, 45)]
		[DataRow(3, 3)]
		[TestMethod]
		public void Test_ComprobarSiEsDivisible_Bool(int num1, int num2) // no olvidar recoger los parámetros
			{
			// Arrange
			// se deja vacío porque se pasan los parámetros con [DataRow(3, 3)]

			// Act
			Prog_Tema_4_Ej_02 SiEsDivisible = new Prog_Tema_4_Ej_02(); // Se crea una instancia del objeto
			bool resultado = SiEsDivisible.ComprobarSiEsDivisible(num1, num2); // En la ejecución del método se recogen los parámetros

			// Assert
			Assert.AreEqual(true, resultado);  // con este único Assert se evaluarán los dos DataRow
											   // No olvidar Compilar antes de ejecutar las Pruebas

			}

		[DataRow(false)]
		[TestMethod]
		public void Text_VerificarContenidoDelString(bool esDivisible)
			{
			// Arrange: recordar que se queda vacío porque se utiliza DataRow para pasar los parámetros

			// Act
			Prog_Tema_4_Ej_02 ValorDelString = new Prog_Tema_4_Ej_02(); // instancia del objeto
			string stringDevuelto = ValorDelString.ValorNegacion(esDivisible);

			// Assert
			Assert.AreNotEqual("NO", stringDevuelto); // En este caso la prueba NO será pasada porque se evalúa lo contrario con AreNotEqual
			// La prueba indica que se esperaba cualquier valor excepto "NO"... dado que el valor que se le pasa a la función es 'false'
			// el método devolverá el string 'NO', que es lo que devolverá. AreNotEqual evalúa que lo devuelto es lo cualquier cosa que 
			// no sea el valor que se le indica.
			}


		}
	}
