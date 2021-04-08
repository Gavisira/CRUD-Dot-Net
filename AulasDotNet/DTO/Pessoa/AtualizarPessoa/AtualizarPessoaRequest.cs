﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.DTO.Pessoa.AtualizarPessoa
{
    public class AtualizarPessoaRequest
    {
        public string nome { get; set; }

        public DateTime dtNascimento { get; set; }

        public string nomeMae { get; set; }

        public string endereco { get; set; }
    }
}
