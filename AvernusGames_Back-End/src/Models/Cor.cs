using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
    public class Cor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Cod { get; set; }
        public string? Nome { get; set; }

        public Cor(){} // Construtor vazio

        public Cor(int cod, string nome)
        {
            Cod = cod;
            Nome = nome;
        } // Construtor com todos os atributos
    }
}