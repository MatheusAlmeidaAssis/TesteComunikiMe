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
    public class ClientesController : ControllerBase
    {
        private readonly IAppServiceCliente _appServiceCliente;

        public ClientesController(IAppServiceCliente appServiceCliente)
        {
            _appServiceCliente = appServiceCliente;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ClienteDto>> Get()
        {
            return Ok(_appServiceCliente.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ClienteDto> Get(int id)
        {
            return Ok(_appServiceCliente.Get(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();

                return Ok(await _appServiceCliente.Add(clienteDto));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                return Ok(await _appServiceCliente.Update(clienteDTO));
            }
            catch (Exception)
            {
                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                return Ok(await _appServiceCliente.Remove(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}