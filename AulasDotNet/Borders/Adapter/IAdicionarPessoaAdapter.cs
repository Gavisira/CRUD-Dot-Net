using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using AulasDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Borders.Adapter
{
    public interface IAdicionarPessoaAdapter
    {
        public Pessoa ConverterRequestParaPessoa(AdicionarPessoaRequest request);
    }
}
