using AulasDotNet.Borders.Repositorios;
using AulasDotNet.Borders.UseCase;
using AulasDotNet.DTO.Pessoa.RetornarPessoaPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.UseCase
{
    public class RetornaPessoaUseCase : IRetornaPessoaUseCase
    {
        private readonly IRepositorioPessoas _repositorioPessoas;
        public RetonarPessoaResponse Executar(int request)
        {
            var response = new RetonarPessoaResponse();
            try
            {
                _repositorioPessoas.RetornaPorId(request);
                response.msg = "Removido com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Erro ao Remover";
                return response;
            }
        }
    }
}
