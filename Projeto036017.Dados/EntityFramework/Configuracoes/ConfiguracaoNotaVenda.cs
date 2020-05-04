using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Dados.EntityFramework.Configuracoes
{
    public class ConfiguracaoNotaVenda : IEntityTypeConfiguration<DominioNotaVenda>
    {
        public void Configure(EntityTypeBuilder<DominioNotaVenda> builder)
        {
            builder.ToTable("NotaVenda", "Projeto036017");
            builder.HasKey("IdNota");
            builder.Property(f => f.IdNota).HasColumnName("IdNota");
            builder.Property(f => f.DataNota).HasColumnName("DataNota");
            builder.Property(f => f.IdItem).HasColumnName("IdItem");
            builder.Property(f => f.IdCliente).HasColumnName("IdCliente");
            builder.Property(f => f.IdVendedor).HasColumnName("IdVendedor");
        }
    }
}
