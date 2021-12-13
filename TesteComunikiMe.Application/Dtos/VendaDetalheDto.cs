namespace TesteComunikiMe.Application.Dtos
{
    public class VendaDetalheDto : DtoBase
    {
        public VendaDto Venda { get; set; }
        public ProdutoDto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}