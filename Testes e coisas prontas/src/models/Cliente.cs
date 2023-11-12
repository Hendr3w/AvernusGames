namespace Avernus_Games_Store.src.models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; private set; }
        public string? Phone { get; set; }
        public Endereco? Endereco { get; set; }
        public List<Venda>? Vendas {get; set;}

        public Cliente() { }

        public Cliente(string nome, string cpf, string email, string senha, string phone, Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Phone = phone;
            Endereco = endereco;
        }
    }
}