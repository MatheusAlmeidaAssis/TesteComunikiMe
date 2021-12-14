using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace TesteComunikiMe.Application.Dtos
{
    public class VendaDto : DtoBase
    {
        [DisplayName("Cliente")]
        public ClienteDto Cliente { get; set; }

        [DisplayName("Produtos")]
        public IEnumerable<VendaDetalheDto> VendaDetalhes { get; set; }

        [DisplayName("Valor Total")]
        public decimal ValorTotal
        {
            get
            {
                return VendaDetalhes.Sum(p => p.Quantidade * p.Produto.Valor);
            }
        }

        public VendaDto()
        {
            VendaDetalhes = new List<VendaDetalheDto>();
        }
    }
}