using Projeto036017.Comum.NotificationPattern;
using Projeto036017.Dados.Repositorio;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Servico.Servicos
{
    public class ServicoPagamento
    {
        private readonly RepositorioPagamento _Pagamento;

        public ServicoPagamento()
        {
            _Pagamento = new RepositorioPagamento();
        }

        public NotificationResult Salvar(DominioPagamento entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (NotificationResult.IsValid)
                {
                    _Pagamento.Adicionar(entidade);
                    NotificationResult.Add("Pagamento cadastrado com sucesso!");
                }

                return NotificationResult;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(DominioPagamento entidade)

        {
            return "";
        }
        public IEnumerable<DominioPagamento> ListarTodos()
        {
            return _Pagamento.ListarTodos();
        }
    }
}
