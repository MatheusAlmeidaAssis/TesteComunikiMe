using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Dtos;

namespace TesteComunikiMe.Application.Core.Interfaces.Services
{
    public interface IAppServiceProduto
    {
        Task<ProdutoDto> Add(ProdutoDto dto);

        Task<ProdutoDto> Update(ProdutoDto dto);

        Task<ProdutoDto> Remove(int id);

        IEnumerable<ProdutoDto> Get();

        ProdutoDto Get(int id);
    }
}