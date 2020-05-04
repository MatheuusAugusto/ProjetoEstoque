using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Dados.EntityFramework.Configuracoes
{
    public class ConfiguracaoPagamento : IEntityTypeConfiguration<DominioPagamento>
    {
        public void Configure(EntityTypeBuilder<DominioPagamento> builder)
        {
            builder.ToTable("Pagamento", "Projeto036017");
            builder.HasKey("IdPagamento");
            builder.Property(f => f.IdPagamento).HasColumnName("IdPagamento");
            builder.Property(f => f.DataLimite).HasColumnName("DataLimite");
            builder.Property(f => f.Valor).HasColumnName("Valor");
            builder.Property(f => f.Pago).HasColumnName("Pago");
            builder.Property(f => f.IdNota).HasColumnName("IdNota");
        }
    }
}
