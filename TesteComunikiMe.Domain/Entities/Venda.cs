using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteComunikiMe.Domain.Entities
{
    public class Venda : EntityBase
    {
        [Required]
        public Cliente Cliente { get; set; }

        [Required]
        public IEnumerable<VendaDetalhe> VendaDetalhes { get; set; }
    }
}