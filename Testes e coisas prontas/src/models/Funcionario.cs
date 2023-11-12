namespace Avernus_Games_Store.src.models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; private set; }
        public string? Phone { get; set; }
        public Endereco? Endereco { get; set; }
        public float ValorHora { get; set; }
        public float NHoras { get; set; }

        // Construtor vazio
        public Funcionario()
        {
            // Inicialize valores padrão, se necessário
        }

        // Construtor com todos os atributos
        public Funcionario(
            int id,
            string nome,
            string cpf,
            string email,
            string senha,
            string phone,
            Endereco endereco,
            float valorHora,
            float nHoras)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Phone = phone;
            Endereco = endereco;
            ValorHora = valorHora;
            NHoras = nHoras;
        }
    }
}