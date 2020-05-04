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
    public class ProdutoController : ControllerBase
    {
        private readonly ServicoProduto servicoProduto;

        public ProdutoController()
        {
            servicoProduto = new ServicoProduto();
        }

        [HttpGet("ListarTodos")]
        public IEnumerable<DominioProduto> ListarTodos()
        {
            return servicoProduto.ListarTodos();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(DominioProduto entidade)
        {
            return servicoProduto.Salvar(entidade);
        }
    }
}