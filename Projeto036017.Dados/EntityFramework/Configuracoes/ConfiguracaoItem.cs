using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Dados.EntityFramework.Configuracoes
{
    public class ConfiguracaoItem : IEntityTypeConfiguration<DominioItem>
    {
        public void Configure(EntityTypeBuilder<DominioItem> builder)
        {
            builder.ToTable("Item", "Projeto036017");
            builder.HasKey("IdItem");
            builder.Property(f => f.IdItem).HasColumnName("IdItem");
            builder.Property(f => f.Preco).HasColumnName("Preco");
            builder.Property(f => f.Quantidade).HasColumnName("Quantidade");
            builder.Property(f => f.IdProduto).HasColumnName("IdProduto");
        }
    }
}
