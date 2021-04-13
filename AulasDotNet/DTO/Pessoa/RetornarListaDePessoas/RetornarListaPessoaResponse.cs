using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.DTO.Pessoa.RetornarListaDePessoas

{
    public class RetornarListaPessoaResponse
    {
        public List<AulasDotNet.Entities.Pessoa> pessoas { get; set; }
        public string msg { get; set; }
    }
}
