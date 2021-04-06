using AulasDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Services
{
    public interface IPessoaService
    {
        bool AdicionarPessoa(Pessoa pessoa);
        List<Pessoa> RetornarListaPessoas();
        Pessoa RetornaPessoaPorId(int id);
        bool AtualizaPessoa(Pessoa pessoa);
        bool DeletaPessoa(int id);
    }
}
