using BlazorShop.Api.Entities;

namespace BlazorShop.Api.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> GetDescricaoProduto(int id);
    }
}
