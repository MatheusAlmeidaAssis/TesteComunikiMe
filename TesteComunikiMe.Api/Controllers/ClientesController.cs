using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TesteComunikiMe.Application.Core.Interfaces.Services;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Application.Services;
using TesteComunikiMe.Utilities.Conts;

namespace TesteComunikiMe.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IAppServiceCliente _appServiceCliente;

        public ClientesController(AppServiceCliente appServiceCliente)
        {
            _appServiceCliente = appServiceCliente;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_appServiceCliente.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_appServiceCliente.Get(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                _appServiceCliente.Add(clienteDto);
                return Ok(Mensagens.RegistroCadatrado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _appServiceCliente.Update(clienteDTO);
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
                _appServiceCliente.Remove(id);
                return Ok(Mensagens.RegistroRemovido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}