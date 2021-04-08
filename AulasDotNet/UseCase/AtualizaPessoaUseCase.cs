using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.Borders.UseCase;
using AulasDotNet.DTO.Pessoa.AtualizarPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.UseCase
{
    public class AtualizaPessoaUseCase : IAtualizaPessoaUseCase
    {
        private readonly IRepositorioPessoas _repositorioPessoas;
        private readonly IAtualizarPessoaAdapter _adapter;
        public AtualizarPessoaResponse Executar(AtualizarPessoaRequest request)
        {
            var response = new AtualizarPessoaResponse();
            try
            {

                var pessoaAdicionar = _adapter.ConverterRequestParaPessoa(request);
                _repositorioPessoas.Add(pessoaAdicionar);


                response.msg = "Atualizado com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Erro ao Atualizar";
                return response;
            }
        }
    }
}
