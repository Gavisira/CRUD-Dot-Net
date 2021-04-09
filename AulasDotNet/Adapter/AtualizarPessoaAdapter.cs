using AulasDotNet.Borders.Adapter;
using AulasDotNet.DTO.Pessoa.AtualizarPessoa;
using AulasDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Adapter
{
    public class AtualizarPessoaAdapter : IAtualizarPessoaAdapter
    {
        public Pessoa ConverterRequestParaPessoa(AtualizarPessoaRequest request)
        {
            var novaPessoa = new Pessoa();
            novaPessoa.id = request.id;
            novaPessoa.nome = request.nome;
            novaPessoa.dtNascimento = request.dtNascimento;
            novaPessoa.endereco = request.endereco;
            novaPessoa.nomeMae = request.nomeMae;
            return novaPessoa;
        }
    }
}
