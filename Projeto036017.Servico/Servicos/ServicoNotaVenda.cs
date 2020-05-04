using Projeto036017.Comum.NotificationPattern;
using Projeto036017.Dados.Repositorio;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Servico.Servicos
{
    public class ServicoNotaVenda
    {
        private readonly RepositorioNotaVenda _NotaVenda;

        public ServicoNotaVenda()
        {
            _NotaVenda = new RepositorioNotaVenda();
        }

        public NotificationResult Salvar(DominioNotaVenda entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (NotificationResult.IsValid)
                {
                    _NotaVenda.Adicionar(entidade);
                    NotificationResult.Add("Nota de venda cadastrada com sucesso!");
                }

                return NotificationResult;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(DominioNotaVenda entidade)

        {
            return "";
        }
        public IEnumerable<DominioNotaVenda> ListarTodos()
        {
            return _NotaVenda.ListarTodos();
        }
    }
}
