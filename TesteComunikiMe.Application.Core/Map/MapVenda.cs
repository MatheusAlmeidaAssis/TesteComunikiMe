using System.Collections.Generic;
using System.Linq;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Application.Core.Map
{
    public class MapVenda : IMapVenda
    {
        private readonly IMapCliente _mapCliente;
        private readonly IMapVendaDetalhe _mapVendaDetalhe;

        public MapVenda(IMapCliente mapCliente, IMapVendaDetalhe mapVendaDetalhe)
        {
            _mapCliente = mapCliente;
            _mapVendaDetalhe = mapVendaDetalhe;
        }

        public Venda MapDtoToEntity(VendaDto dto)
        {
            return new Venda
            {
                Id = dto.Id,
                Cliente = _mapCliente.MapDtoToEntity(dto.Cliente),
                VendaDetalhes = _mapVendaDetalhe.MapDtoList(dto.VendaDetalhes)
            };
        }

        public VendaDto MapEntityToDto(Venda entity)
        {
            return new VendaDto
            {
                Id = entity.Id,
                Cliente = _mapCliente.MapEntityToDto(entity.Cliente),
                VendaDetalhes = _mapVendaDetalhe.MapListDto(entity.VendaDetalhes)
            };
        }

        public IEnumerable<VendaDto> MapListDto(IEnumerable<Venda> entities)
        {
            return entities.Select(p => MapEntityToDto(p));
        }
    }
}