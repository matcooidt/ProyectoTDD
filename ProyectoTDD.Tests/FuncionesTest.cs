using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoTDD;

namespace ProyectoTDD.Tests
{
    [TestClass]
    public class FuncionesTest
    {
        // ===== CalcularFactorial =====

        [TestMethod]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno()
        {
            long resultado = Funciones.CalcularFactorial(-5);
            Assert.AreEqual(-1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            long resultado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Uno_DevuelveUno()
        {
            long resultado = Funciones.CalcularFactorial(1);
            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cinco_Devuelve120()
        {
            long resultado = Funciones.CalcularFactorial(5);
            Assert.AreEqual(120L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Diez_Devuelve3628800()
        {
            long resultado = Funciones.CalcularFactorial(10);
            Assert.AreEqual(3628800L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Veinte_DevuelveValorMaximoDeLong()
        {
            long resultado = Funciones.CalcularFactorial(20);
            Assert.AreEqual(2432902008176640000L, resultado);
        }
    }
}
