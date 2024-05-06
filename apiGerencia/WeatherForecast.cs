namespace apiGerencia
{
    public class Metodos
    {
        public double obterPesoIdeal(float altura, char sexo)
        {
            if (sexo == 'M') {
                return 72.7 * altura;
            }
            if(sexo == 'F')
            {
                return 62.1 * altura;
            }

            throw new ArgumentException(
            "O sexo pode ser apenas 'M' ou 'F'.");
        }
    }
}
