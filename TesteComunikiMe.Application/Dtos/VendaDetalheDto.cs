namespace TesteComunikiMe.Application.Dtos
{
    public class VendaDetalheDto : DtoBase
    {
        public VendaDto Venda { get; set; }
        public ProdutoDto Produto { get; set; }
        public int Quantidade { get; set; }

        public decimal ValorTotal
        {
            get
            {
                return Quantidade * Produto.Valor;
            }
        }
    }
}