using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Core.Interfaces.Services;
using TesteComunikiMe.Application.Dtos;

namespace TesteComunikiMe.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IAppServiceProduto _appServiceProduto;

        public ProdutosController(IAppServiceProduto appServiceProduto)
        {
            _appServiceProduto = appServiceProduto;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ProdutoDto>> Get()
        {
            return Ok(_appServiceProduto.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ProdutoDto> Get(int id)
        {
            return Ok(_appServiceProduto.Get(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                return Ok(await _appServiceProduto.Add(produtoDto));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                return Ok(await _appServiceProduto.Update(produtoDTO));
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return Ok(await _appServiceProduto.Remove(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}