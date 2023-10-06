using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
 namespace Avernus_Games_Store.src.Models
{
    public class Desenvolvedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Estudio { get; set; }
        public string? NomeDesenvolvedor { get; set; }
        public Desenvolvedor(){} // Construtor vazio
        public Desenvolvedor(string estudio, string nomeDesenvolvedor)
        {
            Estudio = estudio;
            NomeDesenvolvedor = nomeDesenvolvedor;

        } // Construtor com todos os atributos
    }
}