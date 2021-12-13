using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TesteComunikiMe.Application.Core.Interfaces.Services;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Utilities.Conts;

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
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_appServiceProduto.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_appServiceProduto.Get(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();

                _appServiceProduto.Add(produtoDto);
                return Ok(Mensagens.RegistroCadatrado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _appServiceProduto.Update(produtoDTO);
                return Ok(Mensagens.RegistroAtualizado);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete(int id)
        {
            try
            {
                _appServiceProduto.Remove(id);
                return Ok(Mensagens.RegistroRemovido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}