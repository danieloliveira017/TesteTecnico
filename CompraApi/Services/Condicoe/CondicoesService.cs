using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraApi.Controllers;
using CompraApi.Data;
using CompraApi.Models;
using CompraApi.Services.interfaces;

namespace CompraApi.Services.Condicoe
{
    public class CondicoesService : ICondicoesInterface
    {
        private readonly DadosCompras _contextCondicoes;

        public CondicoesService(DadosCompras compras){
            _contextCondicoes = compras;
        }

        public async Task<ServiceResponse<List<CodicoesPagamaentoModel>>> AddCondicoes(CodicoesPagamaentoModel condicoes)
        {
            var response = new ServiceResponse<List<CodicoesPagamaentoModel>>();
            try{
                _contextCondicoes.Add(condicoes);
                await _contextCondicoes.SaveChangesAsync();
                response.Dados = new List<CodicoesPagamaentoModel>{condicoes};
                response.Sucesso = true;
                response.Mensagem = "Feito com sucesso";
            }catch(Exception ex){
                response.Mensagem = ex.Message;
                response.Sucesso = false;
            }

            return response;
        }

        public Task<ServiceResponse<List<CodicoesPagamaentoModel>>> DellCondicoes(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<CodicoesPagamaentoModel>>> GetAllCondicoes()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<CodicoesPagamaentoModel>> GetCondicoesById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<CodicoesPagamaentoModel>>> UpdatCondicoes(CodicoesPagamaentoModel condicoes)
        {
            throw new NotImplementedException();
        }
    }
}