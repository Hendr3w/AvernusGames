using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Avernus_Games_Store.src.Models
{
    public abstract class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public float ValorCompra { get; set; }
        public float Markup { get; set; }
        public string? Descricao { get; set; }
        public CatProduto? Categoria { get; set; }
        public Fornecedor? Fornecedor { get; set; }

        [JsonConstructor]
        public Produto(){}

        public Produto(string nome, string codProduto, float valorCompra, float markup, string descricao)
        {
            Nome = nome;
            ValorCompra = valorCompra;
            Markup = markup;
            Descricao = descricao;
            Categoria = new CatProduto(string.Empty, string.Empty);

        }

        public abstract float CalcValorVenda(float ValorCompra, float Markup);


        

    }
}