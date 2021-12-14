using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Core.Interfaces.Services;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Core.Interfaces.Services;

namespace TesteComunikiMe.Application.Services
{
    public class AppServiceCliente : IAppServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapCliente _mapCliente;

        public AppServiceCliente(IServiceCliente serviceCliente, IMapCliente mapCliente)
        {
            _serviceCliente = serviceCliente;
            _mapCliente = mapCliente;
        }

        public async Task<ClienteDto> Add(ClienteDto dto)
        {
            return _mapCliente.MapEntityToDto(await _serviceCliente.Add(_mapCliente.MapDtoToEntity(dto)));
        }

        public IEnumerable<ClienteDto> Get()
        {
            return _mapCliente.MapListDto(_serviceCliente.Get());
        }

        public ClienteDto Get(int id)
        {
            return _mapCliente.MapEntityToDto(_serviceCliente.Get(id));
        }

        public async Task<ClienteDto> Remove(int id)
        {
            return _mapCliente.MapEntityToDto(await _serviceCliente.Remove(id));
        }

        public async Task<ClienteDto> Update(ClienteDto dto)
        {
            return _mapCliente.MapEntityToDto(await _serviceCliente.Update(_mapCliente.MapDtoToEntity(dto)));
        }
    }
}