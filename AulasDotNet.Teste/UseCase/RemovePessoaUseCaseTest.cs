using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.DTO.Pessoa.RemoverPessoa;
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
    public class RemovePessoaUseCaseTest
    {
        private readonly Mock<IRepositorioPessoas> _repositorioPessoas;
        private readonly RemovePessoaUseCase _useCase;

        public RemovePessoaUseCaseTest()
        {
            _repositorioPessoas = new Mock<IRepositorioPessoas>();
            _useCase = new RemovePessoaUseCase(_repositorioPessoas.Object);
        }


        [Fact]
        public void Pessoa_RemovePessoa_Sucesso()
        {
            var request = new RemoverPessoaRequest();
            var response = new RemoverPessoaResponse();
            var pessoa = new Pessoa();
            var produtoId = 1;

            response.msg = "Removido com sucesso";

            _repositorioPessoas.Setup(repositorio => repositorio.Delete(produtoId));

            var result = _useCase.Executar(request);

            response.Should().BeEquivalentTo(result);
        } 

        [Fact]
        public void Pessoa_RemovePessoa_Falha()
        {
            var request = new RemoverPessoaRequest();
            
            var response = new RemoverPessoaResponse();
            var pessoa = new Pessoa();
            var produtoId = 1;
            request.id = produtoId;

            response.msg = "Erro ao Remover";

            _repositorioPessoas.Setup(repositorio => repositorio.Delete(produtoId)).Throws(new Exception());

            var result = _useCase.Executar(request);

            response.Should().BeEquivalentTo(result);
        }
    }
}
