using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto036017.Comum.NotificationPattern;
using Projeto036017.Dominio.Entidades;
using Projeto036017.Servico.Servicos;

namespace Projeto036017.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly ServicoPagamento servicoPagamento;

        public PagamentoController()
        {
            servicoPagamento = new ServicoPagamento();
        }

        [HttpGet("ListarTodos")]
        public IEnumerable<DominioPagamento> ListarTodos()
        {
            return servicoPagamento.ListarTodos();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(DominioPagamento entidade)
        {
            return servicoPagamento.Salvar(entidade);
        }
    }
}