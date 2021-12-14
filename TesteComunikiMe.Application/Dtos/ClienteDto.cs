using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TesteComunikiMe.Utilities.Consts;

namespace TesteComunikiMe.Application.Dtos
{
    public class ClienteDto : DtoBase
    {
        [
            Required(ErrorMessage = Mensagens.CampoObrigatorio),
            StringLength(200)
        ]
        public string Nome { get; set; }

        [
            Required(ErrorMessage = Mensagens.CampoObrigatorio),
            StringLength(200)
        ]
        public string Sobrenome { get; set; }

        [
            DisplayName("E-mail"),
            EmailAddress(ErrorMessage = Mensagens.FormatoInvalido),
            StringLength(100)
        ]
        public string Email { get; set; }

        [Required(ErrorMessage = Mensagens.CampoObrigatorio)]
        public bool Ativo { get; set; }
    }
}