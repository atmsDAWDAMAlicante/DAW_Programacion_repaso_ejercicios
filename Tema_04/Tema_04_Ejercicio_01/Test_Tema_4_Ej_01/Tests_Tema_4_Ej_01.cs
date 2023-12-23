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
            int numero1 = 2;
            int numero2 = 3;

            Prog_Tema_4_Ej_01 sumaTest = new Prog_Tema_4_Ej_01();
            int resultado = sumaTest.Suma(numero1, numero2);

            Assert.AreEqual(5, resultado);
        }
    }
}
