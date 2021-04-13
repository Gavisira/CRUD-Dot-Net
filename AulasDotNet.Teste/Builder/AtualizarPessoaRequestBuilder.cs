using AulasDotNet.DTO.Pessoa.AtualizarPessoa;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasDotNet.Teste.Builder
{
    public class AtualizarPessoaRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AtualizarPessoaRequest _AtualizarPessoa;

        public AtualizarPessoaRequestBuilder()
        {
            _AtualizarPessoa = new AtualizarPessoaRequest();
            _AtualizarPessoa.nome = _faker.Random.String(20);
            _AtualizarPessoa.dtNascimento = _faker.Person.DateOfBirth;
            _AtualizarPessoa.endereco = _faker.Random.String(20);

        }

        public AtualizarPessoaRequest Build()
        {
            AtualizarPessoaRequest _novorequest = _AtualizarPessoa;
            _novorequest.nomeMae = _faker.Random.String(20);
            return _novorequest;
        }

    }
}
