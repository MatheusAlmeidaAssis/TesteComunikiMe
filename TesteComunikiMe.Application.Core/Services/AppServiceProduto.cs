using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Core.Interfaces.Map;
using TesteComunikiMe.Application.Core.Interfaces.Services;
using TesteComunikiMe.Application.Dtos;
using TesteComunikiMe.Domain.Core.Interfaces.Services;

namespace TesteComunikiMe.Application.Services
{
    public class AppServiceProduto : IAppServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapProduto _mapProduto;

        public AppServiceProduto(IServiceProduto serviceProduto, IMapProduto mapProduto)
        {
            _serviceProduto = serviceProduto;
            _mapProduto = mapProduto;
        }

        public async Task<ProdutoDto> Add(ProdutoDto dto)
        {
            return _mapProduto.MapEntityToDto(await _serviceProduto.Add(_mapProduto.MapDtoToEntity(dto)));
        }

        public IEnumerable<ProdutoDto> Get()
        {
            return _mapProduto.MapListDto(_serviceProduto.Get());
        }

        public ProdutoDto Get(int id)
        {
            return _mapProduto.MapEntityToDto(_serviceProduto.Get(id));
        }

        public async Task<ProdutoDto> Remove(int id)
        {
            return _mapProduto.MapEntityToDto(await _serviceProduto.Remove(id));
        }

        public async Task<ProdutoDto> Update(ProdutoDto dto)
        {
            return _mapProduto.MapEntityToDto(await _serviceProduto.Update(_mapProduto.MapDtoToEntity(dto)));
        }
    }
}