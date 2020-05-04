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
    public class ItemController : ControllerBase
    {
        private readonly ServicoItem servicoItem;

        public ItemController()
        {
            servicoItem = new ServicoItem();
        }

        [HttpGet("ListarTodos")]
        public IEnumerable<DominioItem> ListarTodos()
        {
            return servicoItem.ListarTodos();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(DominioItem entidade)
        {
            return servicoItem.Salvar(entidade);
        }
    }
}