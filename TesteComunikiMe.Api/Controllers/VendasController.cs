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
    public class VendasController : ControllerBase
    {
        private readonly IAppServiceVenda _appServiceVenda;

        public VendasController(IAppServiceVenda appServiceVenda)
        {
            _appServiceVenda = appServiceVenda;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<VendaDto>> Get()
        {
            return Ok(_appServiceVenda.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<VendaDto> Get(int id)
        {
            return Ok(_appServiceVenda.Get(id));
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] VendaDto vendaDto)
        {
            try
            {
                if (vendaDto == null)
                    return NotFound();

                return Ok(await _appServiceVenda.Add(vendaDto));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] VendaDto vendaDto)
        {
            try
            {
                if (vendaDto == null)
                    return NotFound();

                return Ok(await _appServiceVenda.Update(vendaDto));
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
                return Ok(await _appServiceVenda.Remove(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}