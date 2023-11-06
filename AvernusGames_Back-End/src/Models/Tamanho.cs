using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
    public class Tamanho
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Cod { get; set; }
        public string? Tag { get; set; }
        public Tamanho(){} // Construtor vazio
    }

}