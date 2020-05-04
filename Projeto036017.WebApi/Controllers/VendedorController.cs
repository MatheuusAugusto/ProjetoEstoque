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
    public class VendedorController : ControllerBase
    {
        private readonly ServicoVendedor servicoVendedor;

        public VendedorController()
        {
            servicoVendedor = new ServicoVendedor();
        }

        [HttpGet("ListarTodos")]
        public IEnumerable<DominioVendedor> ListarTodos()
        {
            return servicoVendedor.ListarTodos();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(DominioVendedor entidade)
        {
            return servicoVendedor.Salvar(entidade);
        }
    }
}