using AulasDotNet.Borders.Adapter;
using AulasDotNet.Borders.Repositorios;
using AulasDotNet.Borders.UseCase;
using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.UseCase
{
    public class AdicionaPessoaUseCase : IAdicionaPessoaUseCase
    {
        private readonly IRepositorioPessoas _repositorioPessoas;
        private readonly IAdicionarPessoaAdapter _adapter;

        public AdicionaPessoaUseCase(IRepositorioPessoas repositorioPessoas, IAdicionarPessoaAdapter adapter)
        {
            _repositorioPessoas = repositorioPessoas;
            _adapter = adapter;
        }

        public AdicionarPessoaResponse Executar(AdicionarPessoaRequest request)
        {
            var response = new AdicionarPessoaResponse();
            try
            {
                
                var pessoaAdicionar = _adapter.ConverterRequestParaPessoa(request);
                _repositorioPessoas.Add(pessoaAdicionar);
                response.msg = "Adicionado com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Erro ao Adicionar";
                return response;
            }

        }
    }
}
