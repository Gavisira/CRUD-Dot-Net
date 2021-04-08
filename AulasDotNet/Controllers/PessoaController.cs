using AulasDotNet.Borders.UseCase;
using AulasDotNet.DTO.Pessoa.AdicionarPessoa;
using AulasDotNet.DTO.Pessoa.AtualizarPessoa;
using AulasDotNet.DTO.Pessoa.RemoverPessoa;
using AulasDotNet.DTO.Pessoa.RetornarPessoaPorId;
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
        private readonly IAdicionaPessoaUseCase _adicionarPessoaUseCase;
        private readonly IAtualizaPessoaUseCase _atualizarPessoaUseCase;
        private readonly IRemoverPessoaUseCase _removerPessoaUseCase;
        private readonly IRetornaListaPessoaUseCase _rtornarListaPessoaUseCase;
        private readonly IRetornaPessoaUseCase _rtornaPessoaUseCase;

        public PessoaController
            (ILogger<PessoaController> logger, 
            IPessoaService pessoa, 
            IAdicionaPessoaUseCase adicionarPessoaUseCase, 
            IAtualizaPessoaUseCase atualizarPessoaUseCase, 
            IRemoverPessoaUseCase removerPessoaUseCase, 
            IRetornaListaPessoaUseCase rtornarListaPessoaUseCase, 
            IRetornaPessoaUseCase rtornaPessoaUseCase)
        {
            _logger = logger;
            _pessoa = pessoa;
            _adicionarPessoaUseCase = adicionarPessoaUseCase;
            _atualizarPessoaUseCase = atualizarPessoaUseCase;
            _removerPessoaUseCase = removerPessoaUseCase;
            _rtornarListaPessoaUseCase = rtornarListaPessoaUseCase;
            _rtornaPessoaUseCase = rtornaPessoaUseCase;
        }

        [HttpGet]
        public IActionResult AllPessoas()
        {
            return Ok(_rtornarListaPessoaUseCase.Executar());
        }
        [HttpGet("{id}")]
        public IActionResult Pessoa([FromBody] RetonarPessoaRequest novaPessoa)
        {
            return Ok(_rtornaPessoaUseCase.Executar(novaPessoa));
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
        public IActionResult PessoaDelete([FromBody] RemoverPessoaRequest request)
        {
            return Ok(_removerPessoaUseCase.Executar(request));
        }
    }
}
