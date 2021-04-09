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

        public RetonarPessoaResponse Executar(int request)
        {
            var response = new RetonarPessoaResponse();
            try
            {
                response.pessoa = _repositorioPessoas.RetornaPorId(request);
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
