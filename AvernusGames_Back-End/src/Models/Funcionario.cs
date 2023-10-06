using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FuncionarioId { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Phone { get; set; }
        public Endereco? Endereco { get; set; }
        public float ValorHora { get; set; }
        public float NHoras { get; set; }

        // Construtor vazio
        public Funcionario(){}

        // Construtor com todos os atributos
        public Funcionario(
            string nome,
            string cpf,
            string email,
            string senha,
            string phone,
            Endereco endereco,
            float valorHora,
            float nHoras)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Phone = phone;
            Endereco = endereco;
            ValorHora = valorHora;
            NHoras = nHoras;
        }
    }
}