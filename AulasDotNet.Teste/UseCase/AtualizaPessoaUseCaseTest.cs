using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.DTO.Pessoa.AtualizarPessoa;
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
    public class AtualizaPessoaUseCaseTest { 



    private readonly Mock<IRepositorioPessoas> _repositorioPessoas;
    private readonly Mock<IAtualizarPessoaAdapter> _atualizarPessoaAdapter;
    private readonly AtualizaPessoaUseCase _useCase;

    public AtualizaPessoaUseCaseTest()
    {
        _repositorioPessoas = new Mock<IRepositorioPessoas>();
            _atualizarPessoaAdapter = new Mock<IAtualizarPessoaAdapter>();
        _useCase = new AtualizaPessoaUseCase(_repositorioPessoas.Object, _atualizarPessoaAdapter.Object);
    }


    [Fact]
    public void Pessoa_AtualizaPessoa_Sucesso()
    {
        var request = new AtualizarPessoaRequestBuilder().Build();
        var response = new AtualizarPessoaResponse();
        var pessoa = new Pessoa();
        var produtoId = 1;

        response.msg = "Atualizado com sucesso";

        _repositorioPessoas.Setup(repositorio => repositorio.Add(pessoa)).Returns(produtoId);
        _atualizarPessoaAdapter.Setup(adapter => adapter.ConverterRequestParaPessoa(request)).Returns(pessoa);

        var result = _useCase.Executar(request);

        response.Should().BeEquivalentTo(result);
    }

    [Fact]
    public void Pessoa_AtualizaPessoa_Falha()
    {
        var request = new AtualizarPessoaRequestBuilder().Build();
        var response = new AtualizarPessoaResponse();
        var pessoa = new Pessoa();
        var produtoId = 1;

        response.msg = "Erro ao Atualizar";

        _repositorioPessoas.Setup(repositorio => repositorio.Add(pessoa)).Returns(produtoId);
        _atualizarPessoaAdapter.Setup(adapter => adapter.ConverterRequestParaPessoa(request)).Throws(new Exception());

        var result = _useCase.Executar(request);

        response.Should().BeEquivalentTo(result);
    }
}
}
