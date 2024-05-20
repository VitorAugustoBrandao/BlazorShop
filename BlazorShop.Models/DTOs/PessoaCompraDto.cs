namespace BlazorShop.Models.DTOs
{
    public class PessoaCompraDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public TimeSpan Timespam { get; set; }

        public int PessoaId { get; set; }
        public string? PessoaNome { get; set; }
    }
}
