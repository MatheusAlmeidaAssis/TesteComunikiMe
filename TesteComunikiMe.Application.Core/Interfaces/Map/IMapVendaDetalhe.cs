using System.Collections.Generic;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Application.Core.Interfaces.Map
{
    public interface IMapVendaDetalhe
    {
        VendaDetalhe MapDtoToEntity(VendaDetalheDto dto);

        IEnumerable<VendaDetalheDto> MapListDto(IEnumerable<VendaDetalhe> entities);

        VendaDetalheDto MapEntityToDto(VendaDetalhe entity);

        IEnumerable<VendaDetalhe> MapDtoList(IEnumerable<VendaDetalheDto> dtos);
    }
}