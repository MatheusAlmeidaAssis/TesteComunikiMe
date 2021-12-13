using System.Collections.Generic;
using System.Threading.Tasks;
using TesteComunikiMe.Application.Dtos;

namespace TesteComunikiMe.Application.Core.Interfaces.Services
{
    public interface IAppServiceCliente
    {
        Task<ClienteDto> Add(ClienteDto dto);

        Task<ClienteDto> Update(ClienteDto dto);

        Task<ClienteDto> Remove(int id);

        IEnumerable<ClienteDto> Get();

        Task<ClienteDto> Get(int id);
    }
}