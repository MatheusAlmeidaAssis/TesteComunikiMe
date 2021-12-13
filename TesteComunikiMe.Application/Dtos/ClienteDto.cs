namespace TesteComunikiMe.Application.Dtos
{
    public class ClienteDto : DtoBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}