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
    public class VendasController : ControllerBase
    {
        private readonly IAppServiceVenda _appServiceVenda;

        public VendasController(IAppServiceVenda appServiceVenda)
        {
            _appServiceVenda = appServiceVenda;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_appServiceVenda.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_appServiceVenda.Get(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] VendaDto vendaDto)
        {
            try
            {
                if (vendaDto == null)
                    return NotFound();

                _appServiceVenda.Add(vendaDto);
                return Ok(Mensagens.RegistroCadatrado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] VendaDto vendaDto)
        {
            try
            {
                if (vendaDto == null)
                    return NotFound();

                _appServiceVenda.Update(vendaDto);
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
                _appServiceVenda.Remove(id);
                return Ok(Mensagens.RegistroRemovido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}