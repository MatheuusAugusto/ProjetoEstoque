using Projeto036017.Comum.NotificationPattern;
using Projeto036017.Dados.Repositorio;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Servico.Servicos
{
    public class ServicoVendedor
    {
        private readonly RepositorioVendedor _Vendedor;

        public ServicoVendedor()
        {
            _Vendedor = new RepositorioVendedor();
        }

        public NotificationResult Salvar(DominioVendedor entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (NotificationResult.IsValid)
                {
                    _Vendedor.Adicionar(entidade);
                    NotificationResult.Add("Vendedor cadastrado com sucesso!");
                }

                return NotificationResult;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(DominioVendedor entidade)

        {
            return "";
        }
        public IEnumerable<DominioVendedor> ListarTodos()
        {
            return _Vendedor.ListarTodos();
        }
    }
}
