using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
    public class Editora
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        public Editora(){} // Construtor vazio

        public Editora(string nome, string email, string telefone)
        {
            
            Nome = nome;
            Email = email;
            Telefone = telefone;
        } // Construtor com todos os atributos
    }
}