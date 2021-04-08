using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.Borders.UseCase;
using AulasDotNet.DTO.Pessoa.RemoverPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.UseCase
{
    public class RemoverPessoaUseCase : IRemoverPessoaUseCase
    {
        private readonly IRepositorioPessoas _repositorioPessoas;
        public RemoverPessoaResponse Executar(int id)
        {
            var response = new RemoverPessoaResponse();
            try
            {
                _repositorioPessoas.Delete(id);
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
