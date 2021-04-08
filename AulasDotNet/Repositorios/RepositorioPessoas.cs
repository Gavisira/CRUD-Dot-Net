﻿using AulasDotNet.Borders.Repositorios;
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

        public void Add(Pessoa request)
        {
            _local.pessoa.Add(request);
            _local.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = _local.pessoa.Where(d => d.id == id).FirstOrDefault();
            _local.pessoa.Remove(obj);
            _local.SaveChanges();
        }

        public Pessoa RetornaPorId(int id)
        {
           return _local.pessoa.Where(d => d.id == id).FirstOrDefault();
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
