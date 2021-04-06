using AulasDotNet.Entities;
using AulasDotNet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasDotNet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;
        private readonly IPessoaService _pessoa;

        public PessoaController(ILogger<PessoaController> logger, IPessoaService pessoa)
        {
            _logger = logger;
            _pessoa = pessoa;
        }

        [HttpGet]
        public IActionResult AllPessoas()
        {
            return Ok(_pessoa.RetornarListaPessoas());
        }
        [HttpGet("{id}")]
        public IActionResult Pessoa(int id)
        {
            return Ok(_pessoa.RetornaPessoaPorId(id));
        }

        [HttpPost]
        public IActionResult PessoaAdd([FromBody] Pessoa novaPessoa)
        {
            return Ok(_pessoa.AdicionarPessoa(novaPessoa));
        }
        [HttpPut]
        public IActionResult PessoaUpdate([FromBody] Pessoa novaPessoa)
        {
            return Ok(_pessoa.AtualizaPessoa(novaPessoa));
        }
        [HttpDelete]
        public IActionResult PessoaDelete(int id)
        {
            return Ok(_pessoa.DeletaPessoa(id));
        }
    }
}
