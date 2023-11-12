namespace Avernus_Games_Store.src.models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CodProduto { get; set; }
        public float? ValorCompra { get; set; }
        public float? Markup { get; set; }
        public string? Descricao { get; set; }
        public CatProduto? Categoria { get; set; }

        public Produto() { }

        public Produto(string nome, string codProduto, float valorCompra, float markup, string descricao)
        {
            Nome = nome;
            CodProduto = codProduto;
            ValorCompra = valorCompra;
            Markup = markup;
            Descricao = descricao;
            Categoria = new CatProduto(string.Empty, string.Empty);

        }

        public class CatProduto
        {
            public string? Categoria { get; set; }
            public string? Descricao { get; set; }
            public CatProduto() { }
            public CatProduto(string categoria, string descricao)
            {
                Categoria = categoria;
                Descricao = descricao;
            }
        }

    }
}