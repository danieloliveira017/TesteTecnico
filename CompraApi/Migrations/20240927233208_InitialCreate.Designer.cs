﻿// <auto-generated />
using CompraApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompraApi.Migrations
{
    [DbContext(typeof(DadosCompras))]
    [Migration("20240927233208_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("CompraApi.Models.CodicoesPagamaentoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QtdeParcelas")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorEntrada")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Condicoes");
                });

            modelBuilder.Entity("CompraApi.Models.ProdutoModel", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.HasKey("Codigo");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("CompraApi.Models.CodicoesPagamaentoModel", b =>
                {
                    b.HasOne("CompraApi.Models.ProdutoModel", "Produto")
                        .WithMany("Condicoes")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CompraApi.Models.ProdutoModel", b =>
                {
                    b.Navigation("Condicoes");
                });
#pragma warning restore 612, 618
        }
    }
}