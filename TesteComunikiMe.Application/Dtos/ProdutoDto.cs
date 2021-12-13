namespace TesteComunikiMe.Application.Dtos
{
    public class ProdutoDto : DtoBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}