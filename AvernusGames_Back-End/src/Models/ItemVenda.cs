using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class ItemVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemVendaId { get; set; }
        public Produto? Produto { get; set; }
        public int Qtd { get; set; }
        public ItemVenda(){}
        public ItemVenda(Produto produto, int qtd)
        {
            Produto = produto;
            Qtd = qtd;

        }
    }
}