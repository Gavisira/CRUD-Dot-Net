using AulasDotNet.DTO.Pessoa.AtualizarPessoa;
using AulasDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Borders.Adapter
{
    public interface IAtualizarPessoaAdapter
    {
        public Pessoa ConverterRequestParaPessoa(AtualizarPessoaRequest request);
    }
}
