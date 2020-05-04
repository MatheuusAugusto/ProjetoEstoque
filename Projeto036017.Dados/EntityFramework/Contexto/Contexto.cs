
using Projeto036017.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Projeto036017.Dados.EntityFramework.Contexto
{
    public class Contexto : DbContext
    {

        //1. CLASSES - ENTIDADES - TABELAS
        //1. INICIO
        //EXEMPLO
        //public DbSet<Departamento> Departamento { get; set; }
        public DbSet<DominioMarca> DominioMarca { get; set; }
        public DbSet<DominioProduto> DominioProduto { get; set; }
        public DbSet<DominioItem> DominioItem { get; set; }
        public DbSet<DominioNotaVenda> DominioNotaVenda { get; set; }
        public DbSet<DominioCliente> DominioCliente { get; set; }
        public DbSet<DominioVendedor> DominioVendedor { get; set; }
        public DbSet<DominioPagamento> DominioPagamento { get; set; }
        //1. FIM

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Já deixe com a configuração pronta pra vocês :)
            optionsBuilder.UseSqlServer("server=201.62.57.93;database=dbLAB2_2020;user id=visualstudio;password=visualstudio;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //2. DEFINIÇÃO DAS CONFIGURAÇÕES DAS CLASSES
            //2. INICIO
            //Exemplo
            //modelBuilder.ApplyConfiguration(new DepartamentoConfiguracao());
            modelBuilder.ApplyConfiguration(new Configuracoes.ConfiguracaoMarca());
            modelBuilder.ApplyConfiguration(new Configuracoes.ConfiguracaoProduto());
            modelBuilder.ApplyConfiguration(new Configuracoes.ConfiguracaoItem());
            modelBuilder.ApplyConfiguration(new Configuracoes.ConfiguracaoNotaVenda());
            modelBuilder.ApplyConfiguration(new Configuracoes.ConfiguracaoCliente());
            modelBuilder.ApplyConfiguration(new Configuracoes.ConfiguracaoVendedor());
            modelBuilder.ApplyConfiguration(new Configuracoes.ConfiguracaoPagamento());
            //2. FIM
        }

    }
}
