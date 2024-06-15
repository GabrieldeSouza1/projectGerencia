using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;



namespace apiGerencia.Tests.UnitTest
{
    [TestClass]
    public class TestIDade
    {
        [TestMethod]
        public void testCalcularIdade()
        {
            var metodos = new Metodos();
            int result = metodos.calcularIdade(new DateTime(2003, 1, 20));

            Assert.AreEqual(21, result);
        }
    }
}