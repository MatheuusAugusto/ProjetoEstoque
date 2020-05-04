using Projeto036017.Dados.EntityFramework.Contexto;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto036017.Dados.Repositorio
{
    public class RepositorioNotaVenda : RepositorioBase<DominioNotaVenda>
    {
        public IEnumerable<DominioNotaVenda> ListarTodos()
        {
            return Contexto.DominioNotaVenda;
        }
    }
}
