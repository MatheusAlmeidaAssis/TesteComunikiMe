using System.Collections.Generic;

namespace TesteComunikiMe.Application.Dtos
{
    public class VendaDto : DtoBase
    {
        public ClienteDto Cliente { get; set; }
        public IEnumerable<VendaDetalheDto> VendaDetalhes { get; set; }
    }
}