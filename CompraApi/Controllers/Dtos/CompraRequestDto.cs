using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompraApi.Models
{
    public class CompraRequestDto
    {
        public ProdutoModel? Produto {get; set;} 
        public CodicoesPagamaentoModel? CondicaoPagamento {get; set;}
        public int Produtoid {get; set;}

    }
}