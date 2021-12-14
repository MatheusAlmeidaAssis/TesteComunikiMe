using System.ComponentModel.DataAnnotations.Schema;

namespace TesteComunikiMe.Application.Dtos
{
    public class DtoBase
    {
        [Column(Order = 0)]
        public int Id { get; set; }
    }
}