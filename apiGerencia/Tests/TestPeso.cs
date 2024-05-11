using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace apiGerencia.Tests
{
    [TestClass]
    public class TestPeso
    {
        [TestMethod]
        public void testObterPesoIdeal()
        {
            string teste = "Apenas par haver mudaça no codigo v2";
            var metodos = new Metodos();
            double result = metodos.obterPesoIdeal(1.80, 'M') ;

            Assert.AreEqual(72.86, result);
        }

        [TestMethod]
        public void testCalcualarIMC()
        {
            var metodos = new Metodos();
            double result = metodos.calcualarIMC(90, 1.75);

            Assert.AreEqual(29.39, result);
        }

        [TestMethod]
        public void testSituacaoIMC()
        {
            var metodos = new Metodos();
            string result = metodos.obterSituacaoIMC(16);

            Assert.AreEqual("Muito abaixo do peso", result);
        }
    }
}