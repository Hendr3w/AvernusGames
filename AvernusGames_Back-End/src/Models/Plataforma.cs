using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
     public class Plataforma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlataformaID { get; set; }
        public string? Nome { get; set; }
        public string? Desc { get; set; }
        public Plataforma(){} // Construtor vazio
        public Plataforma(string nome, string descricao)
        {
            Nome = nome;
            Desc = descricao;
        } // Construtor com todos os atributos
    }
}