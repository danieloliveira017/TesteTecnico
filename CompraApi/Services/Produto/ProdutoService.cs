using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraApi.Data;
using CompraApi.Models;
using CompraApi.Services.interfaces;
using Microsoft.AspNetCore.Routing.Tree;

namespace CompraApi.Services.Produto
{
    public class ProdutoService : IProdutoInterface
    {
        private readonly DadosCompras _contextProduto;
        public ProdutoService(DadosCompras compras){
            _contextProduto = compras;
        }

        public async Task<ServiceResponse<List<ProdutoModel>>> AddProduto(ProdutoModel produto)
        {
            var response = new ServiceResponse<List<ProdutoModel>>();
            try{
                _contextProduto.Produtos.Add(produto);
                await _contextProduto.SaveChangesAsync();
                
               
                response.Dados = new List<ProdutoModel>{produto};
                response.Sucesso = true;
                response.Mensagem = "Produto cadastrado";
                
                
            }catch(Exception ex){
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
        }

        public async Task<ServiceResponse<ProdutoModel>> AtualizarPrecoProduto(int id, decimal Newpreco)
        {
            var response = new ServiceResponse<ProdutoModel>();
            var produto = await _contextProduto.Produtos.FindAsync(id);
            try{

            if(produto == null){
                response.Mensagem = "Produto não encontrado";
                response.Sucesso = false;
                return response;
            }
            if(produto.Preco == Newpreco){
                response.Mensagem = "Preço não alterado";
                response.Sucesso = false;
                return response;
            }
            produto.Preco = Newpreco;
            await _contextProduto.SaveChangesAsync();

            response.Dados = produto;
            response.Sucesso = true;
            response.Mensagem = "Preco atualizado";
            }catch(Exception ex){
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
        }

        public async Task<ServiceResponse<ProdutoModel>> CalcularDesconto(int id, decimal desconto)
        {
           var response = new ServiceResponse<ProdutoModel>();
           var produto = await _contextProduto.Produtos.FindAsync(id);
           try{

            if(produto == null){
                response.Sucesso = false;
                response.Mensagem = "Produto não encontrado";
                return response;
            }
            var ValorDesconto = produto.Preco -(produto.Preco * desconto / 100);
            produto.Preco = ValorDesconto;
            await _contextProduto.SaveChangesAsync();

            response.Dados = produto;
            response.Sucesso = true;
            response.Mensagem = "DEsconto";
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

        public async Task<ServiceResponse<ProdutoModel>> VerificarEstoqueProduto(int id, int quantidades)
        {
            var response = new ServiceResponse<ProdutoModel>();
            var produto = await _contextProduto.Produtos.FindAsync(id);
            try{
                if(produto == null){
                    response.Sucesso = false;
                    response.Mensagem = "Produto não encontrado";
                    return response;
                }

                
               var estoqueDisponivel = produto.QuantidadeEmEstoque >= quantidades;
            
               response.Dados = produto;
               response.Sucesso = true;
               response.Mensagem = estoqueDisponivel ? "Quantidade do estoque suficiente": "Quantidade em estoque insuficiente";

            }catch(Exception ex){
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }
            return response;
        }
    }
}