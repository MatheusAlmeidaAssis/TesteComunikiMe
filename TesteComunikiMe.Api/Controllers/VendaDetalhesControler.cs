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
    public class VendaDetalhesControler : ControllerBase
    {
        private readonly IAppServiceVendaDetalhe _appServiceVendaDetalhe;

        public VendaDetalhesControler(IAppServiceVendaDetalhe appServiceVendaDetalhe)
        {
            _appServiceVendaDetalhe = appServiceVendaDetalhe;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_appServiceVendaDetalhe.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_appServiceVendaDetalhe.Get(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] VendaDetalheDto vendaDetalheDto)
        {
            try
            {
                if (vendaDetalheDto == null)
                    return NotFound();

                _appServiceVendaDetalhe.Add(vendaDetalheDto);
                return Ok(Mensagens.RegistroCadatrado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] VendaDetalheDto vendaDetalheDto)
        {
            try
            {
                if (vendaDetalheDto == null)
                    return NotFound();

                _appServiceVendaDetalhe.Update(vendaDetalheDto);
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
                _appServiceVendaDetalhe.Remove(id);
                return Ok(Mensagens.RegistroRemovido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}