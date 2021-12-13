using System.Collections.Generic;
using System.Linq;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Application.Core.Map
{
    public class MapVendaDetalhe : IMapVendaDetalhe
    {
        private readonly IMapProduto _mapProduto;
        private readonly IMapVenda _mapVenda;

        public MapVendaDetalhe(IMapProduto mapProduto, IMapVenda mapVenda)
        {
            _mapProduto = mapProduto;
            _mapVenda = mapVenda;
        }

        public IEnumerable<VendaDetalhe> MapDtoList(IEnumerable<VendaDetalheDto> dtos)
        {
            return dtos.Select(p => MapDtoToEntity(p));
        }

        public VendaDetalhe MapDtoToEntity(VendaDetalheDto dto)
        {
            return new VendaDetalhe
            {
                Id = dto.Id,
                Produto = _mapProduto.MapDtoToEntity(dto.Produto),
                Quantidade = dto.Quantidade,
                Venda = _mapVenda.MapDtoToEntity(dto.Venda)
            };
        }

        public VendaDetalheDto MapEntityToDto(VendaDetalhe entity)
        {
            return new VendaDetalheDto
            {
                Id = entity.Id,
                Produto = _mapProduto.MapEntityToDto(entity.Produto),
                Quantidade = entity.Quantidade,
                Venda = _mapVenda.MapEntityToDto(entity.Venda)
            };
        }

        public IEnumerable<VendaDetalheDto> MapListDto(IEnumerable<VendaDetalhe> entities)
        {
            return entities.Select(p => MapEntityToDto(p));
        }
    }
}