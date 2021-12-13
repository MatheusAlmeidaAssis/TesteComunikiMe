using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Core.Interfaces.Services;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Core.Interfaces.Services;

namespace TesteComunikiMe.Application.Services
{
    public class AppServiceVendaDetalhe : IAppServiceVendaDetalhe
    {
        private readonly IServiceVendaDetalhe _serviceVendaDetalhe;
        private readonly IMapVendaDetalhe _mapVendaDetalhe;

        public AppServiceVendaDetalhe(IServiceVendaDetalhe serviceVendaDetalhe, IMapVendaDetalhe mapVendaDetalhe)
        {
            _serviceVendaDetalhe = serviceVendaDetalhe;
            _mapVendaDetalhe = mapVendaDetalhe;
        }

        public async Task<VendaDetalheDto> Add(VendaDetalheDto dto)
        {
            return _mapVendaDetalhe.MapEntityToDto(await _serviceVendaDetalhe.Add(_mapVendaDetalhe.MapDtoToEntity(dto)));
        }

        public IEnumerable<VendaDetalheDto> Get()
        {
            return _mapVendaDetalhe.MapListDto(_serviceVendaDetalhe.Get());
        }

        public async Task<VendaDetalheDto> Get(int id)
        {
            return _mapVendaDetalhe.MapEntityToDto(await _serviceVendaDetalhe.Get(id));
        }

        public async Task<VendaDetalheDto> Remove(int id)
        {
            return _mapVendaDetalhe.MapEntityToDto(await _serviceVendaDetalhe.Remove(id));
        }

        public async Task<VendaDetalheDto> Update(VendaDetalheDto dto)
        {
            return _mapVendaDetalhe.MapEntityToDto(await _serviceVendaDetalhe.Update(_mapVendaDetalhe.MapDtoToEntity(dto)));
        }
    }
}