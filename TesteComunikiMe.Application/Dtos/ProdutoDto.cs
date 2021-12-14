using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TesteComunikiMe.Utilities.Consts;
using TesteComunikiMe.Utilities.Extensions;

namespace TesteComunikiMe.Application.Dtos
{
    public class ProdutoDto : DtoBase
    {
        [
            DisplayName("Descrição"),
            Required(ErrorMessage = Mensagens.CampoObrigatorio),
            StringLength(200)
        ]
        public string Descricao { get; set; }

        [
            DisplayName("Valor"),
            Required(ErrorMessage = Mensagens.CampoObrigatorio),
            DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)
        ]
        public string Preco
        {
            get
            {
                return Valor.ToString();
            }
            set
            {
                Valor = value.ParseDecimal();
            }
        }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public decimal Valor { get; set; }

        [DisplayName("Quantidade em Estoque")]
        public int QuantidadeEstoque { get; set; }
    }
}