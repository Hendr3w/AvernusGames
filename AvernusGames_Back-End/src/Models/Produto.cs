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
        public int CategoriaId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
        public int FornecedorId { get; set; }

        public Produto(){}
        public abstract float CalcValorVenda(float ValorCompra, float Markup);
    }
}