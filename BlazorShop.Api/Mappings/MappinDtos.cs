using BlazorShop.Api.Entities;
using BlazorShop.Models.DTOs;
using System;

namespace BlazorShop.Api.Mappings
{
    public static class MappinDtos
    {
        public static IEnumerable<ProdutoDto> ConverterProdutosDto(
            this IEnumerable<Produto> produtos)
        {
            return (from produto in produtos
                    select new ProdutoDto
                    {
                        Id = produto.Id,
                        Nome = produto.Nome,
                        Descricao = produto.Descricao,
                        ImagemUrl = produto.ImagemUrl,
                        Preco = produto.Preco,
                        Quantidade = produto.Quantidade
                    }).ToList();
        }

        public static ProdutoDto ConverterProdutoDto(this Produto produto)
        {
            return new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                ImagemUrl = produto.ImagemUrl,
                Preco = produto.Preco,
                Quantidade = produto.Quantidade
            };
        }

        public static IEnumerable<PessoaDto> ConverterPessoaDto(
            this IEnumerable<Pessoa> pessoas)
        {
            return (from pessoa in pessoas
                    select new PessoaDto
                    {
                        Id = pessoa.Id,
                        Nome = pessoa.Nome,
                        Cpf = pessoa.Cpf,
                        DataNascimento = pessoa.DataNascimento
                    }).ToList();
        }

        public static IEnumerable<PessoaCompraDto> ConverterPessoaCompraDto(
            this IEnumerable<PessoaCompra> pessoaCompras)
        {
            return (from pessoaCompra in pessoaCompras
                    select new PessoaCompraDto
                    {
                        Id = pessoaCompra.Id,
                        Descricao = pessoaCompra.Descricao,
                        Timespam = pessoaCompra.Timespam,
                        PessoaId = pessoaCompra.PessoaId,
                        PessoaNome = pessoaCompra.Pessoa.Nome
                    }).ToList();
        }
    }
}
