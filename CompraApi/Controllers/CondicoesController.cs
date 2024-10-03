using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompraApi.Models;
using CompraApi.Services;
using CompraApi.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CompraApi.Controllers
{
   // [ApiController]
    [Route("api/[controller]")]
    public class CondicoesController : ControllerBase
    {
        private readonly ICondicoesInterface _contextCondicoes;
        public CondicoesController(ICondicoesInterface condicoes){
            _contextCondicoes = condicoes;
        }
        [HttpPost]

        public async Task<ActionResult<ServiceResponse<List<CodicoesPagamaentoModel>>>> AddCondicoes(CodicoesPagamaentoModel condicoes){
            var response = await _contextCondicoes.AddCondicoes(condicoes);
            return Ok(response);
        }
        [HttpPost("compra")]
    public async Task<ActionResult<ServiceResponse<List<CompraRequestDto>>>> AddCompra(CompraRequestDto compra){
              if(compra == null || compra.CondicaoPagamento == null){
                return BadRequest( new ServiceResponse<CompraRequestDto>
                
                {
                    Sucesso =false,
                    Mensagem = "O campo CondicaoPagamento é obrigatório.",
                });
                
              }
              var condicoes = new CodicoesPagamaentoModel
              {
              
                ValorEntrada = compra.CondicaoPagamento.ValorEntrada,
                QtdeParcelas = compra.CondicaoPagamento.QtdeParcelas
              };
              var response = await _contextCondicoes.AddCondicoes(condicoes);
              return Ok(response);
    }
    
    
    }
    }
    
        
    
