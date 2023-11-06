using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    //Construtores gerados pelo chat GPT
    public class Game : Produto
    {
        public Genero? Genero { get; set; }
        public int GeneroId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Desenvolvedor? Desenvolvedor { get; set; }
        public int DesenvolvedorId { get; set; }
        public Plataforma? Plataforma { get; set; }
        public int PlataformaId { get; set; }
        public Game(){} // Construtor vazio
        public override float CalcValorVenda(float ValorCompra, float Markup)
        {
            float ValorVenda = ValorCompra * (1 + Markup);
            float taxaImposto = 0.15f; // 15% de imposto
            float ValorTotal = ValorVenda * (1 + taxaImposto);
            return ValorTotal;
        }
    
    }
}
