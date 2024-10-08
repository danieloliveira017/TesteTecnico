﻿// <auto-generated />
using CompraApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompraApi.Migrations
{
    [DbContext(typeof(DadosCompras))]
    partial class DadosComprasModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("CompraApi.Models.CodicoesPagamaentoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("QtdeParcelas")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorEntrada")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

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

                    b.Property<int>("QuantidadeEmEstoque")
                        .HasColumnType("INTEGER");

                    b.HasKey("Codigo");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
