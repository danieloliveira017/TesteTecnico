using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompraApi.Models
{
    public class CodicoesPagamaentoModel
    {
        [Key] 
        public int Id { get; set; }
        public decimal ValorEntrada {get; set;}
        public int QtdeParcelas {get; set;}

        public int ProdutoId {get; set;}
        public ProdutoModel? Produto {get; set;}
    }
}