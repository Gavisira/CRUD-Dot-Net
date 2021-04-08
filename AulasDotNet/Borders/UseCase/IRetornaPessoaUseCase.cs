using AulasDotNet.DTO.Pessoa.RetornarPessoaPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Borders.UseCase
{
    public interface IRetornaPessoaUseCase
    {
        RetonarPessoaResponse Executar(RetonarPessoaRequest request);
    }
}
