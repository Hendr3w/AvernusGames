using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class Vestimenta : Produto
    {
        public Vestimenta(){} // Construtor vazio
        public override float CalcValorVenda(float ValorCompra, float Markup)
        {
             float ValorVenda = ValorCompra * (1 + Markup);
            float taxaImposto = 0.19f; // 19% de imposto
            float ValorTotal = ValorVenda * (1 + taxaImposto);
            return ValorTotal;
        }
    }
}
