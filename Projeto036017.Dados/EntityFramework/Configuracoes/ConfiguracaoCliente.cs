using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Dados.EntityFramework.Configuracoes
{
    public class ConfiguracaoCliente : IEntityTypeConfiguration<DominioCliente>
    {
        public void Configure(EntityTypeBuilder<DominioCliente> builder)
        {
            builder.ToTable("Cliente", "Projeto036017");
            builder.HasKey("IdCliente");
            builder.Property(f => f.IdCliente).HasColumnName("IdCliente");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.CPF).HasColumnName("CPF");
            builder.Property(f => f.Endereco).HasColumnName("Endereco");
            builder.Property(f => f.Telefone).HasColumnName("Telefone");
        }
    }
}
