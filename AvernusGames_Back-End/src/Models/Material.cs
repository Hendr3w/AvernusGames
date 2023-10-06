using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
    public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Cod { get; set; }
        public string? Desc { get; set; }

        public Material(){} // Construtor vazio

        public Material(int cod, string desc)
        {
            Cod = cod;
            Desc = desc;
        } // Construtor com todos os atributos
    }
}