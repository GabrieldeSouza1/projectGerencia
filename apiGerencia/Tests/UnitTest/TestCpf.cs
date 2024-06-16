using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace apiGerencia.Tests.UnitTest
{
    [TestClass]
    public class TestCpf
    {
        [TestMethod]
        public void testObterCpfOfuscado()
        {
            var metodos = new Metodos();
            string result = metodos.obterCpfOfuscado("111.111.111-51");
        
            Assert.AreEqual("***.111.***-**", result);
        }

        [TestMethod]
        public void validaCpfValido()
        {
            var metodos = new Metodos();
            bool result = metodos.validarCPF("019.877.006-51");

            Assert.AreEqual(true, result);
        }

    }
}
