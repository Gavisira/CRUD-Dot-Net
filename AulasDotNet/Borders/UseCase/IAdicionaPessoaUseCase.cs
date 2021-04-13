using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Borders.UseCase
{
    public interface IAdicionaPessoaUseCase
    {
        AdicionarPessoaResponse Executar(AdicionarPessoaRequest request);
    }
}
