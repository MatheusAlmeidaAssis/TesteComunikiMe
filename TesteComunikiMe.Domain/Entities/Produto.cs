using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteComunikiMe.Domain.Entities
{
    public class Produto : EntityBase
    {
        [Required, StringLength(200)]
        public string Descricao { get; set; }

        public decimal Valor { get; set; }
        public int QuantidadeEstoque { get; set; }

        public IEnumerable<VendaDetalhe> VendaDetalhes { get; set; }
    }
}