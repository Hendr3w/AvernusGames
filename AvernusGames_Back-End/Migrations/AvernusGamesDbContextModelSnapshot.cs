﻿// <auto-generated />
using System;
using Avernus_Games_Store.src.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Avernus_Games_v2.Migrations
{
    [DbContext(typeof(AvernusGamesDbContext))]
    partial class AvernusGamesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("CatProduto");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Cor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cod")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cor");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Desenvolvedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Estudio")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDev")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Desenvolvedor");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Editora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Editora");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("Num")
                        .HasColumnType("longtext");

                    b.Property<string>("Pais")
                        .HasColumnType("longtext");

                    b.Property<string>("Rua")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CNPJ")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<float>("NHoras")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.Property<float>("ValorHora")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.ItemVenda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Qtd")
                        .HasColumnType("int");

                    b.Property<int>("VendaId1")
                        .HasColumnType("int");

                    b.HasKey("VendaId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId1");

                    b.ToTable("ItemVenda");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cod")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Plataforma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Plataforma");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<float>("Markup")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<float>("ValorCompra")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produto");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Sistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Tamanho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cod")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tamanho");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Nf")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.VestCor", b =>
                {
                    b.Property<int>("CorId")
                        .HasColumnType("int");

                    b.Property<int>("VestimentaId")
                        .HasColumnType("int");

                    b.HasKey("CorId", "VestimentaId");

                    b.HasIndex("VestimentaId");

                    b.ToTable("VestCor");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.VestMaterial", b =>
                {
                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("VestimentaId")
                        .HasColumnType("int");

                    b.HasKey("MaterialId", "VestimentaId");

                    b.HasIndex("VestimentaId");

                    b.ToTable("VestMaterial");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.VestTamanho", b =>
                {
                    b.Property<int>("TamanhoId")
                        .HasColumnType("int");

                    b.Property<int>("VestimentaId")
                        .HasColumnType("int");

                    b.HasKey("TamanhoId", "VestimentaId");

                    b.HasIndex("VestimentaId");

                    b.ToTable("VestTamanho");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Game", b =>
                {
                    b.HasBaseType("Avernus_Games_Store.src.Models.Produto");

                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("PlataformaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.HasIndex("DesenvolvedorId");

                    b.HasIndex("GeneroId");

                    b.HasIndex("PlataformaId");

                    b.ToTable("Game", (string)null);
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.RPGame", b =>
                {
                    b.HasBaseType("Avernus_Games_Store.src.Models.Produto");

                    b.Property<int>("EditoraId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SistemaId")
                        .HasColumnType("int");

                    b.HasIndex("EditoraId");

                    b.HasIndex("SistemaId");

                    b.ToTable("RPGame", (string)null);
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Vestimenta", b =>
                {
                    b.HasBaseType("Avernus_Games_Store.src.Models.Produto");

                    b.ToTable("Vestimenta", (string)null);
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Cliente", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Fornecedor", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Funcionario", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.ItemVenda", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Venda", "Venda")
                        .WithMany("Itens")
                        .HasForeignKey("VendaId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Produto", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Venda", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.VestCor", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Cor", "Cor")
                        .WithMany()
                        .HasForeignKey("CorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Vestimenta", "Vestimenta")
                        .WithMany()
                        .HasForeignKey("VestimentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cor");

                    b.Navigation("Vestimenta");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.VestMaterial", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Vestimenta", "Vestimenta")
                        .WithMany()
                        .HasForeignKey("VestimentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Vestimenta");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.VestTamanho", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Tamanho", "Tamanho")
                        .WithMany()
                        .HasForeignKey("TamanhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Vestimenta", "Vestimenta")
                        .WithMany()
                        .HasForeignKey("VestimentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tamanho");

                    b.Navigation("Vestimenta");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Game", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany()
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Produto", null)
                        .WithOne()
                        .HasForeignKey("Avernus_Games_Store.src.Models.Game", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Plataforma", "Plataforma")
                        .WithMany()
                        .HasForeignKey("PlataformaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desenvolvedor");

                    b.Navigation("Genero");

                    b.Navigation("Plataforma");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.RPGame", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Editora", "Editora")
                        .WithMany()
                        .HasForeignKey("EditoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Produto", null)
                        .WithOne()
                        .HasForeignKey("Avernus_Games_Store.src.Models.RPGame", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Avernus_Games_Store.src.Models.Sistema", "Sistema")
                        .WithMany()
                        .HasForeignKey("SistemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Editora");

                    b.Navigation("Sistema");
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Vestimenta", b =>
                {
                    b.HasOne("Avernus_Games_Store.src.Models.Produto", null)
                        .WithOne()
                        .HasForeignKey("Avernus_Games_Store.src.Models.Vestimenta", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Avernus_Games_Store.src.Models.Venda", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
