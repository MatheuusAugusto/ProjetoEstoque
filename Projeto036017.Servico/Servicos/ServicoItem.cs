using Projeto036017.Comum.NotificationPattern;
using Projeto036017.Dados.Repositorio;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Servico.Servicos
{
    public class ServicoItem
    {
        private readonly RepositorioItem _Item;

        public ServicoItem()
        {
            _Item = new RepositorioItem();
        }

        public NotificationResult Salvar(DominioItem entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (NotificationResult.IsValid)
                {
                    _Item.Adicionar(entidade);
                    NotificationResult.Add("Item cadastrado com sucesso!");
                }

                return NotificationResult;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(DominioItem entidade)

        {
            return "";
        }
        public IEnumerable<DominioItem> ListarTodos()
        {
            return _Item.ListarTodos();
        }
    }
}
