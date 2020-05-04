using Projeto036017.Dados.EntityFramework.Contexto;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto036017.Dados.Repositorio
{
    public class RepositorioPagamento : RepositorioBase<DominioPagamento>
    {
        public IEnumerable<DominioPagamento> ListarTodos()
        {
            return Contexto.DominioPagamento;
        }
    }
}
