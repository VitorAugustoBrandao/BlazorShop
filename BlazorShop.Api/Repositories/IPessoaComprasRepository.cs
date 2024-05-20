using BlazorShop.Api.Entities;

namespace BlazorShop.Api.Repositories
{
    public interface IPessoaComprasRepository
    {
        Task<IEnumerable<PessoaCompra>> GetPessoaCompras();
    }
}
