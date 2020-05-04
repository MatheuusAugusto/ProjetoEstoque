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
    public class NotaVendaController : ControllerBase
    {
        private readonly ServicoNotaVenda servicoNotaVenda;

        public NotaVendaController()
        {
            servicoNotaVenda = new ServicoNotaVenda();
        }

        [HttpGet("ListarTodos")]
        public IEnumerable<DominioNotaVenda> ListarTodos()
        {
            return servicoNotaVenda.ListarTodos();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(DominioNotaVenda entidade)
        {
            return servicoNotaVenda.Salvar(entidade);
        }
    }
}