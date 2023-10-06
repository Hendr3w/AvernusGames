using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class RPGame : Produto
    {
        public Editora? Editora { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public Sistema? Sistema { get; set; }

        public RPGame(){} // Construtor vazio

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

        public override float CalcValorVenda(float ValorCompra, float Markup)
        {
            float ValorVenda = ValorCompra * (1 + Markup);
            float taxaImposto = 0.15f; // 15% de imposto
            float ValorTotal = ValorVenda * (1 + taxaImposto);
            return ValorTotal;
        }
    }
}
