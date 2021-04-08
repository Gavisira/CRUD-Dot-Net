using AulasDotNet.Borders.Repositorios;
using AulasDotNet.Borders.UseCase;
using AulasDotNet.DTO.Pessoa.RetornarListaDePessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.UseCase
{
    public class RetornaListaPessoaUseCase : IRetornaListaPessoaUseCase
    {
        private readonly IRepositorioPessoas _repositorioPessoas;
        public RetornarListaPessoaResponse Executar()
        {
            var response = new RetornarListaPessoaResponse();
            try
            {
                _repositorioPessoas.RetornarListaPessoas();
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
