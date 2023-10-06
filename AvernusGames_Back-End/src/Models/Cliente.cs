using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Telefone { get; set; }
        
        public Endereco? Endereco { get; set; }
        public int Endereco_id { get; set; }
        //public List<Venda>? Vendas {get; set;}

        public Cliente(){}

        public Cliente(string nome, string cpf, string email, string senha, string phone, Endereco endereco)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            Telefone = phone;
            Endereco = endereco;
        }



    }
}