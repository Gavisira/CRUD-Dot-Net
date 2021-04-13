using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.DTO.Pessoa.RetornarListaDePessoas;
using AulasDotNet.Entities;
using AulasDotNet.Teste.Builder;
using AulasDotNet.UseCase;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AulasDotNet.Teste.UseCase
{
    public class RetornaListaPessoaUseCaseTest
    {
        private readonly Mock<IRepositorioPessoas> _repositorioPessoas;
        private readonly RetornaListaPessoaUseCase _useCase;

        public RetornaListaPessoaUseCaseTest()
        {
            _repositorioPessoas = new Mock<IRepositorioPessoas>();
            _useCase = new RetornaListaPessoaUseCase(_repositorioPessoas.Object);
        }

        [Fact]
        public void Pessoa_RetornaListaPessoa_Sucesso()
        {
            var request = new RetornarListaPessoaRequest();
            var response = new RetornarListaPessoaResponse();
            var pessoa = new Pessoa();
            var produtoId = 1;

            response.msg = "Retornado com sucesso";

            _repositorioPessoas.Setup(repositorio => repositorio.RetornarListaPessoas());

            var result = _useCase.Executar();

            response.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Pessoa_RetornaListaPessoa_Falha()
        {
            var request = new RetornarListaPessoaRequest();

            var response = new RetornarListaPessoaResponse();
            var pessoa = new Pessoa();
            var produtoId = 1;

            response.msg = "Erro ao Retornar";

            _repositorioPessoas.Setup(repositorio => repositorio.RetornarListaPessoas()).Throws(new Exception());

            var result = _useCase.Executar();

            response.Should().BeEquivalentTo(result);
        }
    }
}
