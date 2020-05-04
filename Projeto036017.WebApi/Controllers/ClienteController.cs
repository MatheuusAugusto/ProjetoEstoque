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
    public class ClienteController : ControllerBase
    {
        private readonly ServicoCliente servicoCliente;

        public ClienteController()
        {
            servicoCliente = new ServicoCliente();
        }

        [HttpGet("ListarTodos")]
        public IEnumerable<DominioCliente> ListarTodos()
        {
            return servicoCliente.ListarTodos();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(DominioCliente entidade)
        {
            return servicoCliente.Salvar(entidade);
        }
    }
}