using System.Collections.Generic;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Application.Core.Interfaces.Map
{
    public interface IMapVenda
    {
        Venda MapDtoToEntity(VendaDto dto);

        IEnumerable<VendaDto> MapListDto(IEnumerable<Venda> entities);

        VendaDto MapEntityToDto(Venda entity);
    }
}