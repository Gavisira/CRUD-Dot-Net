using AulasDotNet.DTO.Pessoa.RemoverPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Borders.UseCase
{
    public interface IRemoverPessoaUseCase
    {
        RemoverPessoaResponse Executar(int request);
    }
}
