namespace Avernus_Games_Store.src.models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string? CNPJ { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Endereco? Endereco { get; set; }

        public Fornecedor() { }

        public Fornecedor(string cnpj, string nome, string email, string phone, Endereco endereco)
        {
            CNPJ = cnpj;
            Nome = nome;
            Email = email;
            Phone = phone;
            Endereco = endereco;
        }
    }
}