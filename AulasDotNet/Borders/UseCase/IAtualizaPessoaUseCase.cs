using AulasDotNet.DTO.Pessoa.AtualizarPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulasDotNet.DTO.Pessoa.AdicionarPessoa;

namespace AulasDotNet.Borders.UseCase
{
    public interface IAtualizaPessoaUseCase
    {
        AtualizarPessoaResponse Executar(AtualizarPessoaRequest request);
    }
}
