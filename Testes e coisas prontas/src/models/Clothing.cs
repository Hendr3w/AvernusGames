namespace Avernus_Games_Store.src.models
{
    public class Clothing : Produto
    {
        public List<Cor>? Cores { get; set; }
        public List<Tamanho>? Tamanhos { get; set; }
        public List<Material>? Materials { get; set; }

        public Clothing() { } // Construtor vazio

        public Clothing(
            string nome, 
            string codProduto, 
            float valorCompra, 
            float markup, 
            string descricao, 
            List<Cor> cores, 
            List<Tamanho> tamanhos, 
            List<Material> materials)
            : base(nome, codProduto, valorCompra, markup, descricao)
        {
            Cores = cores;
            Tamanhos = tamanhos;
            Materials = materials;
        } // Construtor com todos os atributos
    }

    public class Cor
    {
        public int Cod { get; set; }
        public string? Nome { get; set; }

        public Cor() { } // Construtor vazio

        public Cor(int cod, string nome)
        {
            Cod = cod;
            Nome = nome;
        } // Construtor com todos os atributos
    }

    public class Tamanho
    {
        public int Cod { get; set; }
        public string? Tag { get; set; }

        public Tamanho() { } // Construtor vazio

        public Tamanho(int cod, string tag)
        {
            Cod = cod;
            Tag = tag;
        } // Construtor com todos os atributos
    }

    public class Material
    {
        public int Cod { get; set; }
        public string? Desc { get; set; }

        public Material() { } // Construtor vazio

        public Material(int cod, string desc)
        {
            Cod = cod;
            Desc = desc;
        } // Construtor com todos os atributos
    }
}
