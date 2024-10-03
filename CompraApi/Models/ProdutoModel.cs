using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompraApi.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Codigo {get; set;}
        [Required]
        public string Nome {get; set;} = string.Empty;
        [Required]
        public decimal Preco {get; set;}
         public int QuantidadeEmEstoque { get; set; }

    

        
    }
}