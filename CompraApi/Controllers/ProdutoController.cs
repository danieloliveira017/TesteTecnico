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
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoInterface _produtoService;
        public ProdutoController(IProdutoInterface produtoInterface){
            _produtoService= produtoInterface;
        }
       
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<ProdutoModel>>>> AddProduto(ProdutoModel produto){
            var response = await _produtoService.AddProduto(produto);
            return Ok(response);
        }

    }
}