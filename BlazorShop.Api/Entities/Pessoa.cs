using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Api.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
    }
}
