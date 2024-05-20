using BlazorShop.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Api.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly AppDbContext _context;
        public PessoaRepository(AppDbContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<Pessoa>> GetPessoas()
        {
            var pessoas = await _context.Pessoas.ToListAsync();

            return pessoas;
        }
    }
}
