using AulasDotNet.Borders.Adapter;
using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using AulasDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Adapter
{
    public class AdicionarPessoaAdapter : IAdicionarPessoaAdapter
    {
        public Pessoa ConverterRequestParaPessoa(AdicionarPessoaRequest request)
        {
            var novaPessoa = new Pessoa();
            novaPessoa.nome = request.nome;
            novaPessoa.dtNascimento = request.dtNascimento;
            novaPessoa.endereco = request.endereco;
            novaPessoa.nomeMae = request.nomeMae;
            return novaPessoa;
        }
    }
}
