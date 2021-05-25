using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasDotNet.Teste.Builder
{
    public class AdicionarPessoaRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarPessoaRequest _adicionarPessoa;

        public AdicionarPessoaRequestBuilder()
        {
            _adicionarPessoa = new AdicionarPessoaRequest();
            _adicionarPessoa.nome = _faker.Random.String(20);
            _adicionarPessoa.dtNascimento = _faker.Person.DateOfBirth;
            _adicionarPessoa.endereco = _faker.Random.String(20);
             
        }

        public AdicionarPessoaRequest Build()
        {
            AdicionarPessoaRequest _novorequest = _adicionarPessoa;
            _novorequest.nomeMae = _faker.Random.String(20);
            return _novorequest;
        }

        public AdicionarPessoaRequest BuildErro()
        {
            return _adicionarPessoa;
        }
    }
}
