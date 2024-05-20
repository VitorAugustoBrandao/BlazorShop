using BlazorShop.Models.DTOs;

namespace BlazorShop.Web.Services;

public interface IProdutoService
{
    Task<IEnumerable<ProdutoDto>> GetProdutos();
    Task<ProdutoDto> GetDescricaoProduto(int id);
}
