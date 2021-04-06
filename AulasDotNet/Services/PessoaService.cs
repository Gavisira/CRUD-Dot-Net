using AulasDotNet.Context;
using AulasDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Services
{
    public class PessoaService : IPessoaService
    {

        private readonly LocalDBContext _local;

        public PessoaService(LocalDBContext local)
        {
            _local = local;
        }

        public bool AdicionarPessoa(Pessoa pessoa)
        {
            _local.pessoa.Add(pessoa);
            _local.SaveChanges();
            return true;

        }

        public bool AtualizaPessoa(Pessoa novo)
        {
            _local.pessoa.Attach(novo);
            _local.Entry(novo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletaPessoa(int id)
        {
           var obj = _local.pessoa.Where(d => d.id == id).FirstOrDefault();
            _local.pessoa.Remove(obj);
            _local.SaveChanges();
            return true;
        }

        public Pessoa RetornaPessoaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> RetornarListaPessoas()
        {
          return  _local.pessoa.ToList();
        }
    }
}
