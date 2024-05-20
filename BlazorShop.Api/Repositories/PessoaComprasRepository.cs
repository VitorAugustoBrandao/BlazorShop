using BlazorShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Api.Repositories
{
    public class PessoaComprasRepository : IPessoaComprasRepository
    {
        private readonly AppDbContext _context;
        public PessoaComprasRepository(AppDbContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<PessoaCompra>> GetPessoaCompras()
        {
            var pessoaCompras = await _context.pessoaCompras.ToListAsync();

            return pessoaCompras;
        }
    }
}
