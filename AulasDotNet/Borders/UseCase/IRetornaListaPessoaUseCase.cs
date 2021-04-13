using AulasDotNet.DTO.Pessoa.RetornarListaDePessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Borders.UseCase
{
    public interface IRetornaListaPessoaUseCase
    {
        RetornarListaPessoaResponse Executar();
    }
}
