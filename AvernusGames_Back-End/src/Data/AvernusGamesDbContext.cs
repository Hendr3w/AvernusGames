using Microsoft.EntityFrameworkCore;
using Avernus_Games_Store.src.Models;
using static Avernus_Games_Store.src.Models.Produto;

namespace Avernus_Games_Store.src.Data
{
    public class AvernusGamesDbContext : DbContext 
    {
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Funcionario>? Funcionario { get; set; }
        public DbSet<Fornecedor>? Fornecedor { get; set; }
        public DbSet<Produto>? Produto { get; set; }
        public DbSet<CatProduto>? CatProduto { get; set; }
        public DbSet<Game>? Game { get; set; }
        public DbSet<Genero>? Genero { get; set; }
        public DbSet<Plataforma>? Plataforma { get; set; }
        public DbSet<Desenvolvedor>? Desenvolvedor { get; set; }
        public DbSet<RPGame>? RPGame { get; set; }
        public DbSet<Editora>? Editora { get; set; }
        public DbSet<Sistema>? Sistema { get; set; }
        public DbSet<Vestimenta>? Vestimenta { get; set; }
        public DbSet<Cor>? Cor { get; set; }
        public DbSet<Material>? Material { get; set; }
        public DbSet<Tamanho>? Tamanho { get; set; }
        public DbSet<Venda>? Venda { get; set; }
        public DbSet<ItemVenda>? ItemVenda { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().ToTable("Game");
            modelBuilder.Entity<RPGame>().ToTable("RPGame");
            modelBuilder.Entity<Vestimenta>().ToTable("Vestimenta");

            modelBuilder.Entity<VestCor>().HasKey(cc => new { cc.CorId, cc.VestimentaId });
            modelBuilder.Entity<VestTamanho>().HasKey(cc => new { cc.TamanhoId, cc.VestimentaId });
            modelBuilder.Entity<VestMaterial>().HasKey(cc => new { cc.MaterialId, cc.VestimentaId });



            
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Avernus;User=root;Password=12345678;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

    }
}


