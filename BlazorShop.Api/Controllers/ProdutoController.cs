using BlazorShop.Api.Mappings;
using BlazorShop.Api.Repositories;
using BlazorShop.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetProdutos()
        {
            try
            {
                var produtos = await _produtoRepository.GetProdutos();
                if (produtos == null)
                {
                    return NotFound();
                }
                else
                {
                    var produtoDtos = produtos.ConverterProdutosDto();
                    return Ok(produtoDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProdutoDto>> GetDescricaoProduto(int id)
        {
            try
            {
                var produtoDescricao = await _produtoRepository.GetDescricaoProduto(id);
                if (produtoDescricao == null)
                {
                    return BadRequest("Erro ao localizar o produto");
                }
                else
                {
                    var produtoDtos = produtoDescricao.ConverterProdutoDto();
                    return Ok(produtoDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
    }
}
