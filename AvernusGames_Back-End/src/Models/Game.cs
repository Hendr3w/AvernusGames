using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avernus_Games_Store.src.Models
{
    //Construtores gerados pelo chat GPT
    public class Game
    {   

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public float ValorCompra { get; set; }
        public float Markup { get; set; }  
        public Fornecedor? Fornecedor { get; set; }
        public int FornecedorId { get; set; }
        public Genero? Genero { get; set; }
        public int GeneroId { get; set; }
        public Desenvolvedor? Desenvolvedor { get; set; }
        public int DesenvolvedorId { get; set; }
        public Plataforma? Plataforma { get; set; }
        public int PlataformaId { get; set; }
        public Game(){} // Construtor vazio
        
    
    }
}
