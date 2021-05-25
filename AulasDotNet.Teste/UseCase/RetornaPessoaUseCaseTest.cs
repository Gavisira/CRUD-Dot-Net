using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.DTO.Pessoa.RetornarPessoaPorId;
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
    public class RetornaPessoaUseCaseTest
    {
        private readonly Mock<IRepositorioPessoas> _repositorioPessoas;
        private readonly RetornaPessoaUseCase _useCase;

        public RetornaPessoaUseCaseTest()
        {
            _repositorioPessoas = new Mock<IRepositorioPessoas>();
            _useCase = new RetornaPessoaUseCase(_repositorioPessoas.Object);
        }


        [Fact]
        public void Pessoa_RetornaPessoa_Sucesso()
        {
            var request = new RetornarPessoaRequest();
            var response = new RetornarPessoaResponse();
            var pessoa = new Pessoa();
            var produtoId = 1;

            response.msg = "Retornado com sucesso";

            _repositorioPessoas.Setup(repositorio => repositorio.RetornaPorId(produtoId));

            var result = _useCase.Executar(request);

            response.Should().BeEquivalentTo(result);
        }

        [Fact] 
        public void Pessoa_RetornaPessoa_Falha()
        {
            var request = new RetornarPessoaRequest();

            var response = new RetornarPessoaResponse();
            var pessoa = new Pessoa();
            var produtoId = 1;
            request.id = produtoId;

            response.msg = "Erro ao Retornar";

            _repositorioPessoas.Setup(repositorio => repositorio.RetornaPorId(produtoId)).Throws(new Exception());

            var result = _useCase.Executar(request);

            response.Should().BeEquivalentTo(result);
        }
    }
}
