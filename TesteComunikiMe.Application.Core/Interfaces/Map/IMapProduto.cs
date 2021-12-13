using System.Collections.Generic;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Application.Core.Interfaces.Map
{
    public interface IMapProduto
    {
        Produto MapDtoToEntity(ProdutoDto dto);

        IEnumerable<ProdutoDto> MapListDto(IEnumerable<Produto> entities);

        ProdutoDto MapEntityToDto(Produto entity);
    }
}