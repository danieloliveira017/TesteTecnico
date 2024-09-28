using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraApi.Models;
using CompraApi.Services.interfaces;

namespace CompraApi.Services.Produto
{
    public class ProdutoService : IProdutoInterface
    {
        public Task<ServiceResponse<List<ProdutoModel>>> AddProduto(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<ProdutoModel>>> DeletProduto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<ProdutoModel>>> GetAllProdutos()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<ProdutoModel>> GetProdutoById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<ProdutoModel>>> UpdateProduto(ProdutoModel produto)
        {
            throw new NotImplementedException();
        }
    }
}