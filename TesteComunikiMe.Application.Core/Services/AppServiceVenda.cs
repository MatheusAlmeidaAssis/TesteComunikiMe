using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Core.Interfaces.Services;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Core.Interfaces.Services;

namespace TesteComunikiMe.Application.Services
{
    public class AppServiceVenda : IAppServiceVenda
    {
        private readonly IServiceVenda _serviceVenda;
        private readonly IMapVenda _mapVenda;

        public AppServiceVenda(IServiceVenda serviceVenda, IMapVenda mapVenda)
        {
            _serviceVenda = serviceVenda;
            _mapVenda = mapVenda;
        }

        public async Task<VendaDto> Add(VendaDto dto)
        {
            return _mapVenda.MapEntityToDto(await _serviceVenda.Add(_mapVenda.MapDtoToEntity(dto)));
        }

        public IEnumerable<VendaDto> Get()
        {
            return _mapVenda.MapListDto(_serviceVenda.Get());
        }

        public async Task<VendaDto> Get(int id)
        {
            return _mapVenda.MapEntityToDto(await _serviceVenda.Get(id));
        }

        public async Task<VendaDto> Remove(int id)
        {
            return _mapVenda.MapEntityToDto(await _serviceVenda.Remove(id));
        }

        public async Task<VendaDto> Update(VendaDto dto)
        {
            return _mapVenda.MapEntityToDto(await _serviceVenda.Update(_mapVenda.MapDtoToEntity(dto)));
        }
    }
}