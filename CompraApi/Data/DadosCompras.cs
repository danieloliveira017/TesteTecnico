using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CompraApi.Data
{
    public class DadosCompras: DbContext
    {
        public DadosCompras(DbContextOptions<DadosCompras> options) : base(options){

        }
        
        public DbSet<ProdutoModel> Produtos {get; set;}
        public DbSet<CodicoesPagamaentoModel> Condicoes {get; set;}
    }
}