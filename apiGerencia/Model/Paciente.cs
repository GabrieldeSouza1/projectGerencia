namespace tpGerencia.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Sobrenonme { get; set; }
        public required char Sexo { get; set;}
        public required DateTime Nascimento { get; set; }
        public required byte Idade { get; set; }
        public required double Peso { get; set; }
        public required string Cpf { get; set; }
        public required double Imc { get; set; }
    }
}
