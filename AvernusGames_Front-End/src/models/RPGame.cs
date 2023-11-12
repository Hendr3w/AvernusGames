using System;

namespace Avernus_Games_Store.src.models
{
    public class RPGame : Produto
    {
        public Editora? Editora { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Sistema? Sistema { get; set; }

        public RPGame() { } // Construtor vazio

        public RPGame(
            string nome, 
            string codProduto, 
            float valorCompra, 
            float markup, 
            string descricao, 
            Editora? editora, 
            DateTime? releaseDate, 
            Sistema? sistema)
            : base(nome, codProduto, valorCompra, markup, descricao)
        {
            Editora = editora;
            ReleaseDate = releaseDate;
            Sistema = sistema;
        } // Construtor com todos os atributos
    }

    public class Editora
    {
        public int Cod { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public Editora() { } // Construtor vazio

        public Editora(int cod, string nome, string email, string phone)
        {
            Cod = cod;
            Nome = nome;
            Email = email;
            Phone = phone;
        } // Construtor com todos os atributos
    }

    public class Sistema
    {
        public string? Nome { get; set; }
        public string? Desc { get; set; }

        public Sistema() { } // Construtor vazio

        public Sistema(string nome, string desc)
        {
            Nome = nome;
            Desc = desc;
        } // Construtor com todos os atributos
    }
}
