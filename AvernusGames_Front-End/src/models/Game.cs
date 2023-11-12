namespace Avernus_Games_Store.src.models
{

    //Construtores gerados pelo chat GPT
    public class Game : Produto
    {
        public Genero? Genero { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Desenvolvedor? Desenvolvedor { get; set; }
        public Plataforma? Plataforma { get; set; }
        public Game() { } // Construtor vazio
        public Game(string nome, string codProduto, float valorCompra, float markup, string descricao, Genero genero, DateTime releaseDate, Desenvolvedor desenvolvedor, Plataforma plataforma)
            : base(nome, codProduto, valorCompra, markup, descricao)
        {
            Genero = genero;
            ReleaseDate = releaseDate;
            Desenvolvedor = desenvolvedor;
            Plataforma = plataforma;
        } // Construtor com todos os atributos
    }

    public class Genero
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Genero() { } // Construtor vazio
        public Genero(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        } // Construtor com todos os atributos
    }

    public class Plataforma
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Plataforma() { } // Construtor vazio
        public Plataforma(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        } // Construtor com todos os atributos
    }

    public class Desenvolvedor
    {
        public string? Estudio { get; set; }
        public string? NomeDesenvolvedor { get; set; }
        public Endereco? Endereco { get; set; }
        public Desenvolvedor() { } // Construtor vazio
        public Desenvolvedor(string estudio, string nomeDesenvolvedor, Endereco endereco)
        {
            Estudio = estudio;
            NomeDesenvolvedor = nomeDesenvolvedor;
            Endereco = endereco;
        } // Construtor com todos os atributos
    }
}
