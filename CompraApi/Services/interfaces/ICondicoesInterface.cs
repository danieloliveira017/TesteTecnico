using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CompraApi.Models;

namespace CompraApi.Services.interfaces
{
    public interface ICondicoesInterface
    {
        Task<ServiceResponse<List<CodicoesPagamaentoModel>>> GetAllCondicoes();
        Task<ServiceResponse<CodicoesPagamaentoModel>> GetCondicoesById(int id);
        Task<ServiceResponse<List<CodicoesPagamaentoModel>>> AddCondicoes(CodicoesPagamaentoModel condicoes);
        Task<ServiceResponse<List<CodicoesPagamaentoModel>>> UpdatCondicoes(CodicoesPagamaentoModel condicoes);
        Task<ServiceResponse<List<CodicoesPagamaentoModel>>> DellCondicoes(int id);
    }
}