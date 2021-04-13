using AulasDotNet.Borders.Repositorios;
using AulasDotNet.Borders.UseCase;
using AulasDotNet.DTO.Pessoa.RetornarPessoaPorId;
using AulasDotNet.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.UseCase
{
    public class RetornaPessoaUseCase : IRetornaPessoaUseCase
    {
        private readonly IRepositorioPessoas _repositorioPessoas;

        public RetornaPessoaUseCase(IRepositorioPessoas repositorioPessoas)
        {
            _repositorioPessoas = repositorioPessoas;
        }

        public RetornarPessoaResponse Executar(RetornarPessoaRequest request)
        {
            var response = new RetornarPessoaResponse();
            try
            {
                response.pessoa = _repositorioPessoas.RetornaPorId(request.id);
                response.msg = "Retornado com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Erro ao Retornar";
                return response;
            }
        }
    }
}
