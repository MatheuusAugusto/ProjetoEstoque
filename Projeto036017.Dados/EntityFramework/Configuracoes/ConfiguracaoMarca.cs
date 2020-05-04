using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto036017.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto036017.Dados.EntityFramework.Configuracoes
{
    public class ConfiguracaoMarca : IEntityTypeConfiguration<DominioMarca>
    {
        public void Configure(EntityTypeBuilder<DominioMarca> builder)
        {
            builder.ToTable("Marca", "Projeto036017");
            builder.HasKey("IdMarca");
            builder.Property(f => f.IdMarca).HasColumnName("IdMarca");
            builder.Property(f => f.Nome).HasColumnName("Nome");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
        }
    }
}