using BlazorShop.Api.Entities;
using BlazorShop.Api.Mappings;
using BlazorShop.Api.Repositories;
using BlazorShop.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IPessoaComprasRepository _pessoaCompraRepository;

        public PessoaController(IPessoaRepository pessoaRepository, IPessoaComprasRepository pessoaComprasRepository)
        {
            _pessoaRepository = pessoaRepository;
            _pessoaCompraRepository = pessoaComprasRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetPessoas()
        {
            try
            {
                var pessoas = await _pessoaRepository.GetPessoas();
                if (pessoas == null)
                {
                    return NotFound();
                }
                else
                {
                    var pessoasDtos = pessoas.ConverterPessoaDto();
                    return Ok(pessoasDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaCompraDto>>> GetPessoaCompras()
        {
            try
            {
                var pessoaCompras = await _pessoaCompraRepository.GetPessoaCompras();
                if (pessoaCompras == null)
                {
                    return NotFound();
                }
                else
                {
                    var pessoasComprasDtos = pessoaCompras.ConverterPessoaCompraDto();
                    return Ok(pessoasComprasDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
    }
}
