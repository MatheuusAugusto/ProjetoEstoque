using Projeto036017.Comum.NotificationPattern;
using Projeto036017.Dados.Repositorio;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Servico.Servicos
{
    public class ServicoCliente
    {
        private readonly RepositorioCliente _Cliente;

        public ServicoCliente()
        {
            _Cliente = new RepositorioCliente();
        }

        public NotificationResult Salvar(DominioCliente entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (NotificationResult.IsValid)
                {
                    _Cliente.Adicionar(entidade);
                    NotificationResult.Add("Cliente cadastrado com sucesso!");
                }

                return NotificationResult;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(DominioCliente entidade)

        {
            return "";
        }
        public IEnumerable<DominioCliente> ListarTodos()
        {
            return _Cliente.ListarTodos();
        }
    }
}

