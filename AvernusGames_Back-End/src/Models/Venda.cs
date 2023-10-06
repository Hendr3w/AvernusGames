using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class Venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendaId { get; set; }
        public Cliente? Cliente { get; set; }
        public string? Nf { get; set; }
        public List<ItemVenda>? Itens { get; set; }
        public Venda(){}

        public Venda(Cliente cliente, string nf, List<ItemVenda> itens)
        {
            Cliente = cliente;
            Nf = nf;
            Itens = itens;
        }
    }
}