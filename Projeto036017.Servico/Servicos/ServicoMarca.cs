using Projeto036017.Comum.NotificationPattern;
using Projeto036017.Dados.Repositorio;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Servico.Servicos
{
    public class ServicoMarca
    {
        private readonly RepositorioMarca _Marca;

        public ServicoMarca()
        {
            _Marca = new RepositorioMarca();
        }

        public NotificationResult Salvar(DominioMarca entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (NotificationResult.IsValid)
                {
                    _Marca.Adicionar(entidade);
                    NotificationResult.Add("Marca cadastrada com sucesso!");
                }

                return NotificationResult;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }
        public string Excluir(DominioMarca entidade)

        {
            return "";
        }
        public IEnumerable<DominioMarca> ListarTodos()
        {
            return _Marca.ListarTodos();
        }
    }
}
