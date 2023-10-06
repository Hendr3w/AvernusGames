using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Avernus_Games_Store.src.Models
{
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnderecoId {get; set;}
        public string? Pais { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Rua { get; set; }
        public string? Num { get; set; }

        public Endereco(){}
        public Endereco(string estado, string cidade, string rua, string num)
        {
            Pais = "Brasil";
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
            Num = num;
        }

        public Endereco(string pais, string estado, string cidade, string rua, string num)
        {
            Pais = pais;
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
            Num = num;
        }
    }
}