using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraApi.Data;
using CompraApi.Models;
using CompraApi.Services.interfaces;

namespace CompraApi.Services.Produto
{
    public class ProdutoService : IProdutoInterface
    {
        private readonly DadosCompras _contextCompras;
        public ProdutoService(DadosCompras compras){
            _contextCompras = compras;
        }

        public async Task<ServiceResponse<List<ProdutoModel>>> AddProduto(ProdutoModel produto)
        {
            var response = new ServiceResponse<List<ProdutoModel>>();
            try{
                _contextCompras.Produtos.Add(produto);
                await _contextCompras.SaveChangesAsync();
               
                response.Dados = new List<ProdutoModel>{produto};
                response.Sucesso = true;
                response.Mensagem = "Produto cadastrado";
                
                
            }catch(Exception ex){
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
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