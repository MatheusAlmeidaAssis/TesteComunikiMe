using System.Collections.Generic;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Application.Core.Interfaces.Map
{
    public interface IMapCliente
    {
        Cliente MapDtoToEntity(ClienteDto dto);

        IEnumerable<ClienteDto> MapListDto(IEnumerable<Cliente> entities);

        ClienteDto MapEntityToDto(Cliente entity);
    }
}