using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Dados.EntityFramework.Configuracoes
{
    public class ConfiguracaoProduto : IEntityTypeConfiguration<DominioProduto>
    {
        public void Configure(EntityTypeBuilder<DominioProduto> builder)
        {
            builder.ToTable("Produto", "Projeto036017");
            builder.HasKey("IdProduto");
            builder.Property(f => f.IdProduto).HasColumnName("IdProduto");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.Quantidade).HasColumnName("Quantidade");
            builder.Property(f => f.Preco).HasColumnName("Preco");
            builder.Property(f => f.IdMarca).HasColumnName("IdMarca");
        }
    }
}
