using System.Collections.Generic;
using System.Linq;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Application.Core.Map
{
    public class MapCliente : IMapCliente
    {
        public Cliente MapDtoToEntity(ClienteDto dto)
        {
            return new Cliente
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Sobrenome = dto.Sobrenome,
                Email = dto.Email,
                Ativo = dto.Ativo
            };
        }

        public ClienteDto MapEntityToDto(Cliente entity)
        {
            return new ClienteDto
            {
                Id = entity.Id,
                Nome = entity.Nome,
                Sobrenome = entity.Sobrenome,
                Email = entity.Email,
                Ativo = entity.Ativo
            };
        }

        public IEnumerable<ClienteDto> MapListDto(IEnumerable<Cliente> entities)
        {
            return entities.Select(p => MapEntityToDto(p));
        }
    }
}