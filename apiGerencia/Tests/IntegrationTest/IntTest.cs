using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Text.Json;
using tpGerencia.Models;
namespace apiGerencia.Tests.IntegrationTest
{
    [TestClass]
    public class IntTest
    {
        private readonly CustomWebApplicationFactory<Program> _webApplicationFactory;
        private readonly HttpClient _client;

        public IntTest()
        {
            _webApplicationFactory = new CustomWebApplicationFactory<Program>();
            _client = _webApplicationFactory.CreateClient();
        }


        [TestMethod]
        public async Task TestGetPacientes()
        {

            var response = await _client.GetAsync("api/Pacientes");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }


        [TestMethod]
        public async Task TestGetPacientesNotExist()
        {

            var response = await _client.GetAsync("api/Pacientes");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
        [TestMethod]
        public async Task TestCreatePatient()
        {
            var request = new Paciente
            {
                Cpf = "342",
                Idade = 18,
                Imc = 18,
                Nascimento = DateTime.Now,
                Nome = "Teste",
                Peso = 50,
                Sexo = 'M',
                Sobrenonme = "Teste2"
            };


            var response = await _client.PostAsJsonAsync("api/Pacientes", request);

            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }

        [TestMethod]
        public async Task TestDeletPatientNotExist()
        {


            var response = await _client.DeleteAsync($"api/Pacientes/{8}"); ;

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }

        [TestMethod]
        public async Task TestGetPatientByName()
        {

            var response = await _client.GetAsync($"api/Pacientes/byName/{"teste"}"); ;
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
