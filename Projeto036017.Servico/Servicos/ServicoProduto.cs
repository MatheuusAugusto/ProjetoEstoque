using Projeto036017.Comum.NotificationPattern;
using Projeto036017.Dados.Repositorio;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Servico.Servicos
{
    public class ServicoProduto
    {
        private readonly RepositorioProduto _Produto;

        public ServicoProduto()
        {
            _Produto = new RepositorioProduto();
        }

        public NotificationResult Salvar(DominioProduto entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (NotificationResult.IsValid)
                {
                    _Produto.Adicionar(entidade);
                    NotificationResult.Add("Produto cadastrado com sucesso!");
                }

                return NotificationResult;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(DominioProduto entidade)

        {
            return "";
        }
        public IEnumerable<DominioProduto> ListarTodos()
        {
            return _Produto.ListarTodos();
        }
    }
}
