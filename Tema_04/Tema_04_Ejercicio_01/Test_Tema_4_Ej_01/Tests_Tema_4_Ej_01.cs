using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prog_Tema_4_Ej_01_;

namespace Test_Tema_4_Ej_01
{
    [TestClass]
    public class Tests_Tema_4_Ej_01
    {
        [TestMethod]
        public void TestMethodSuma()
        {
            // Arrange
            int numero1 = 2;
            int numero2 = 3;

            // Act
            Prog_Tema_4_Ej_01 sumaTest = new Prog_Tema_4_Ej_01(); // objeto de la clase del Form
            // la variable resultado recoge la ejecución del método del objeto instanciado con los parámetros declarados en Arrange
            int resultado = sumaTest.Suma(numero1, numero2); 

            // Assert
            Assert.AreEqual(5, resultado); // compara el valor esperado con el valor resultante de ejecutar la función
        }
    }
}
