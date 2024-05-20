using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Api.Entities
{
    public class PessoaCompra
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; } = string.Empty;
        public TimeSpan Timespam { get; set; }

        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
    }
}
