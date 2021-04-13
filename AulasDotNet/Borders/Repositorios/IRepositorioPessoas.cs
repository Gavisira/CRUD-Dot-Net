using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using AulasDotNet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Borders.Repositorios
{
    public interface IRepositorioPessoas
    {
        public int Add(Pessoa request);
        public void Update(Pessoa request);
        public bool Delete(int id);
        public Pessoa RetornaPorId(int id);
        public List<Pessoa> RetornarListaPessoas();
    }
}
