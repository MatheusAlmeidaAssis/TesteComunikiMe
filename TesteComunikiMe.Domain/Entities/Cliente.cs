using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TesteComunikiMe.Utilities.Conts;

namespace TesteComunikiMe.Domain.Entities
{
    public class Cliente : EntityBase
    {
        [Required, StringLength(200)]
        public string Nome { get; set; }

        [Required, StringLength(200)]
        public string Sobrenome { get; set; }

        [EmailAddress(ErrorMessage = Mensagens.EmailError), StringLength(100)]
        public string Email { get; set; }

        public bool Ativo { get; set; }
        public IEnumerable<Venda> Vendas { get; set; }
    }
}