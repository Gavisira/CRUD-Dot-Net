using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.DTO.Pessoa.RetornarPessoaPorId
{
    public class RetonarPessoaResponse
    {
        public AulasDotNet.Entities.Pessoa pessoa { get; set; }
        public string msg { get; set; }
    }
}
