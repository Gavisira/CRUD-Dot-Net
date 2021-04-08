using AulasDotNet.Borders.UseCase;
using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using AulasDotNet.DTO.Pessoa.AtualizarPessoa;
using AulasDotNet.Entities;
using AulasDotNet.Services;
using AulasDotNet.UseCase;
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
        private readonly AdicionaPessoaUseCase _adicionarPessoaUseCase;
        private readonly AtualizaPessoaUseCase _atualizarPessoaUseCase;
        private readonly RemoverPessoaUseCase _removerPessoaUseCase;
        private readonly RetornaListaPessoaUseCase _rtornarListaPessoaUseCase;
        private readonly RetornaPessoaUseCase _rtornaPessoaUseCase;
        public PessoaController(ILogger<PessoaController> logger, IPessoaService pessoa)
        {
            _logger = logger;
            _pessoa = pessoa;
        }

        [HttpGet]
        public IActionResult AllPessoas()
        {
            return Ok(_rtornarListaPessoaUseCase.Executar());
        }
        [HttpGet("{id}")]
        public IActionResult Pessoa(int id)
        {
            return Ok(_rtornaPessoaUseCase.Executar(id));
        }

        [HttpPost]
        public IActionResult PessoaAdd([FromBody] AdicionarPessoaRequest novaPessoa)
        {
            return Ok(_adicionarPessoaUseCase.Executar(novaPessoa));
        }
        [HttpPut]
        public IActionResult PessoaUpdate([FromBody] AtualizarPessoaRequest novaPessoa)
        {
            return Ok(_atualizarPessoaUseCase.Executar(novaPessoa));
        }
        [HttpDelete]
        public IActionResult PessoaDelete(int id)
        {
            return Ok(_removerPessoaUseCase.Executar(id));
        }
    }
}
