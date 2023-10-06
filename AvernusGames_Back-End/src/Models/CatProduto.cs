using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
    
    public class CatProduto
    {
        [Key]
        public int CatID { get; set; }
        public string? Categoria { get; set; }
        public string? Desc { get; set; }
        public CatProduto(){}
        public CatProduto(string categoria, string descricao)
        {
            Categoria = categoria;
            Desc = descricao;
        }
    }
    
}