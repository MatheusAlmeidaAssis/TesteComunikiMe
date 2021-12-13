using System.Collections.Generic;
using System.Linq;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Entities;

namespace TesteComunikiMe.Application.Core.Map
{
    public class MapProduto : IMapProduto
    {
        public Produto MapDtoToEntity(ProdutoDto dto)
        {
            return new Produto
            {
                Id = dto.Id,
                Descricao = dto.Descricao,
                QuantidadeEstoque = dto.QuantidadeEstoque,
                Valor = dto.Valor
            };
        }

        public ProdutoDto MapEntityToDto(Produto entity)
        {
            return new ProdutoDto
            {
                Id = entity.Id,
                Descricao = entity.Descricao,
                Valor = entity.Valor,
                QuantidadeEstoque = entity.QuantidadeEstoque
            };
        }

        public IEnumerable<ProdutoDto> MapListDto(IEnumerable<Produto> entities)
        {
            return entities.Select(p => MapEntityToDto(p));
        }
    }
}