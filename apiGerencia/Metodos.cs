using NuGet.Versioning;

namespace apiGerencia
{
    public class Metodos
    {
        public double obterPesoIdeal(float altura, char sexo)
        {
            if (sexo == 'M')
            {
                return 72.7 * altura;
            }
            if (sexo == 'F')
            {
                return 62.1 * altura;
            }

            throw new ArgumentException(
            "O sexo pode ser apenas 'M' ou 'F'.");
        }

        public double calcualarIMC(float peso, float altura)
        {
            return peso/(altura*altura);

        }

        public int calcularIdade(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
        public string obterSituacaoIMC(float imc)
        {
            if (imc < 17) return "Muito abaixo do peso";
            if (imc < 18.49) return "Abaixo do peso";
            if (imc < 24.99) return "Peso normal";
            if (imc < 29.99) return "Acima do peso";
            if (imc < 34.99) return "Obesidade I";
            if (imc < 39.99) return "Obesidade II (severa)";
            return "Obesidade III (mórbida)";
        }

        public string obterCpfOfuscado(string cpf)
        {
            string[] partes = cpf.Split('.');
            string meio = partes[1];
            return "***." + meio + ".***-**";
        }

        public bool validarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
