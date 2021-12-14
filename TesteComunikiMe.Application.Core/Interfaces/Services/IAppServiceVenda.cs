using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Dtos;

namespace TesteComunikiMe.Application.Core.Interfaces.Services
{
    public interface IAppServiceVenda
    {
        Task<VendaDto> Add(VendaDto dto);

        Task<VendaDto> Update(VendaDto dto);

        Task<VendaDto> Remove(int id);

        IEnumerable<VendaDto> Get();

        VendaDto Get(int id);
    }
}