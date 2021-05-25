using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
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
    public class AdicionaPessoaUseCaseTest
    {
        private readonly Mock<IRepositorioPessoas> _repositorioPessoas;
        private readonly Mock<IAdicionarPessoaAdapter> _adicionarPessoaAdapter;
        private readonly AdicionaPessoaUseCase _useCase;

        public AdicionaPessoaUseCaseTest()
        {
            _repositorioPessoas = new Mock<IRepositorioPessoas>();
            _adicionarPessoaAdapter = new Mock<IAdicionarPessoaAdapter>();
            _useCase = new AdicionaPessoaUseCase(_repositorioPessoas.Object, _adicionarPessoaAdapter.Object);
        }


        [Fact]
        public void Pessoa_AdicionaPessoa_Sucesso()
        {
            var request = new AdicionarPessoaRequestBuilder().Build();
            var response = new AdicionarPessoaResponse(); 
            var pessoa = new Pessoa();
            var produtoId = 1;
           
            response.msg = "Adicionado com sucesso";

            _repositorioPessoas.Setup(repositorio => repositorio.Add(pessoa)).Returns(produtoId);
            _adicionarPessoaAdapter.Setup(adapter => adapter.ConverterRequestParaPessoa(request)).Returns(pessoa);

            var result = _useCase.Executar(request);

            response.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Pessoa_AdicionaPessoa_Falha()
        {
            var request = new AdicionarPessoaRequestBuilder().Build();
            var response = new AdicionarPessoaResponse();
            var pessoa = new Pessoa();
            var produtoId = 1;

            response.msg = "Erro ao Adicionar";

            _repositorioPessoas.Setup(repositorio => repositorio.Add(pessoa)).Returns(produtoId);
            _adicionarPessoaAdapter.Setup(adapter => adapter.ConverterRequestParaPessoa(request)).Throws(new Exception());

            var result = _useCase.Executar(request);

            response.Should().BeEquivalentTo(result);
        }
    }
}
