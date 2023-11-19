using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Telefone { get; set; }
        public Endereco? Endereco { get; set; }
        public int EnderecoId { get; set; }
        public float ValorHora { get; set; }
        public float NHoras { get; set; }
        public Funcionario(){}
    }
}