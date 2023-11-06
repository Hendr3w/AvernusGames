using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class ItemVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        public int Qtd { get; set; }
        public ItemVenda(){}
    }
}