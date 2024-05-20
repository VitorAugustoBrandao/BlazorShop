using BlazorShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Api.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context) 
        { 
            _context = context;
        }

        public async Task<Produto> GetDescricaoProduto(int id)
        {
            var produto = await _context.Produtos.SingleOrDefaultAsync(c => c.Id == id);

            return produto;
        }

        public async Task<IEnumerable<Produto>> GetProdutos()
        {
            var produtos = await _context.Produtos.ToListAsync();

            return produtos;
        }
    }
}
