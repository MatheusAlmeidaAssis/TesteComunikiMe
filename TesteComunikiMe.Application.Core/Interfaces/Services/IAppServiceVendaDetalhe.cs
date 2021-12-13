using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Dtos;

namespace TesteComunikiMe.Application.Core.Interfaces.Services
{
    public interface IAppServiceVendaDetalhe
    {
        Task<VendaDetalheDto> Add(VendaDetalheDto dto);

        Task<VendaDetalheDto> Update(VendaDetalheDto dto);

        Task<VendaDetalheDto> Remove(int id);

        IEnumerable<VendaDetalheDto> Get();

        Task<VendaDetalheDto> Get(int id);
    }
}