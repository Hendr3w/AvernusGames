using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
    public class Genero
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            public string? Nome { get; set; }
            public string? Desc { get; set; }
            public Genero(){} // Construtor vazio
        }
}