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
    public class MarcaController : ControllerBase
    {
        private readonly ServicoMarca servicoMarca;

        public MarcaController()
        {
            servicoMarca = new ServicoMarca();
        }

        [HttpGet("ListarTodos")]
        public IEnumerable<DominioMarca> ListarTodos()
        {
            return servicoMarca.ListarTodos();
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(DominioMarca entidade)
        {
            return servicoMarca.Salvar(entidade);
        }
    }
}