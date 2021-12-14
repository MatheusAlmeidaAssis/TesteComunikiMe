using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteComunikiMe.Domain.Entities
{
    public class Cliente : EntityBase
    {
        [Required, StringLength(200)]
        public string Nome { get; set; }

        [Required, StringLength(200)]
        public string Sobrenome { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public bool Ativo { get; set; }
        public IEnumerable<Venda> Vendas { get; set; }
    }
}