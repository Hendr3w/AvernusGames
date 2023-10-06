using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
    public class Tamanho
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TamanhoId { get; set; }
        public int Cod { get; set; }
        public string? Tag { get; set; }

        public Tamanho(){} // Construtor vazio

        public Tamanho(int cod, string tag)
        {
            Cod = cod;
            Tag = tag;
        } // Construtor com todos os atributos
    }

}