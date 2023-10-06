using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class Vestimenta : Produto
    {
        public List<Cor>? Cores { get; set; }
        public List<Tamanho>? Tamanhos { get; set; }
        public List<Material>? Materiais { get; set; }

        public Vestimenta(){} // Construtor vazio

        public Vestimenta(
            string nome, 
            string codProduto, 
            float valorCompra, 
            float markup, 
            string descricao, 
            List<Cor> cores, 
            List<Tamanho> tamanhos, 
            List<Material> materiais)
            : base(nome, codProduto, valorCompra, markup, descricao)
        {
            Cores = cores;
            Tamanhos = tamanhos;
            Materiais = materiais;
        } // Construtor com todos os atributos 

        public override float CalcValorVenda(float ValorCompra, float Markup)
        {
             float ValorVenda = ValorCompra * (1 + Markup);
            float taxaImposto = 0.19f; // 19% de imposto
            float ValorTotal = ValorVenda * (1 + taxaImposto);
            return ValorTotal;
        }
    }
}
