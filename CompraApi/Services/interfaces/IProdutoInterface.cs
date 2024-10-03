using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraApi.Models;

namespace CompraApi.Services.interfaces
{
    public interface IProdutoInterface
    {
         Task<ServiceResponse<List<ProdutoModel>>> GetAllProdutos();
         Task<ServiceResponse<ProdutoModel>> GetProdutoById(int id);
         Task<ServiceResponse<List<ProdutoModel>>> AddProduto(ProdutoModel produto);
         Task<ServiceResponse<List<ProdutoModel>>> UpdateProduto(ProdutoModel produto);
         Task<ServiceResponse<List<ProdutoModel>>> DeletProduto(int id);
         Task<ServiceResponse<ProdutoModel>> AtualizarPrecoProduto(int id, decimal Newpreco);
         Task<ServiceResponse<ProdutoModel>> CalcularDesconto(int id, decimal desconto);
         Task<ServiceResponse<ProdutoModel>> VerificarEstoqueProduto(int id, int quantidades); 
    }
}