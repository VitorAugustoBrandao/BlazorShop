using BlazorShop.Api.Entities;

namespace BlazorShop.Api.Repositories
{
    public interface IPessoaRepository
    {
        Task<IEnumerable<Pessoa>> GetPessoas();
    }
}
