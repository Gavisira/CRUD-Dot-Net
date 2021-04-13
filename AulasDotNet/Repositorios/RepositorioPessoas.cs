using AulasDotNet.Borders.Repositorios;
using AulasDotNet.Context;
using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using AulasDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Repositorios
{
    public class RepositorioPessoas : IRepositorioPessoas
    {
        private LocalDBContext _local;

        public RepositorioPessoas(LocalDBContext local)
        {
            _local = local;
        }

        public int Add(Pessoa request)
        {
            _local.pessoa.Add(request);
            _local.SaveChanges();
            return request.id;
        }

        public bool Delete(int id)
        {
            var obj = _local.pessoa.Where(d => d.id == id).FirstOrDefault();
            _local.pessoa.Remove(obj);
            _local.SaveChanges();
            return true;

        }

        public Pessoa RetornaPorId(int id)
        {
            foreach(Pessoa p in _local.pessoa)
            {
                if (p.id.Equals(id))
                {
                    return p;
                } 
            }
            return null;
        }

        public List<Pessoa> RetornarListaPessoas()
        {
            return _local.pessoa.ToList();
        }

        public void Update(Pessoa request)
        {
            _local.pessoa.Attach(request);
            _local.Entry(request).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _local.SaveChanges();
        }
    }
}
