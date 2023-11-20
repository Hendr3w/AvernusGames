using Microsoft.EntityFrameworkCore;
using Avernus_Games_Store.src.Models;

namespace Avernus_Games_Store.src.Data
{
    public class AvernusGamesDbContext : DbContext 
    {
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Funcionario>? Funcionario { get; set; }
        public DbSet<Fornecedor>? Fornecedor { get; set; }
        public DbSet<Game>? Game { get; set; }
        public DbSet<Genero>? Genero { get; set; }
        public DbSet<Plataforma>? Plataforma { get; set; }
        public DbSet<Desenvolvedor>? Desenvolvedor { get; set; }
        public DbSet<Venda>? Venda { get; set; }
        public DbSet<ItemVenda>? ItemVenda { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Avernus;User=root;Password=12345678;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}


