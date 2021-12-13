using System.ComponentModel.DataAnnotations;

namespace TesteComunikiMe.Domain.Entities
{
    public class VendaDetalhe : EntityBase
    {
        [Required]
        public Venda Venda { get; set; }

        [Required]
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}