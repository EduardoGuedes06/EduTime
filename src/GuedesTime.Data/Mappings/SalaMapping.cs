﻿
using GuedesTime.Domain.Models;
using GuedesTime.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GuedesTime.Data.Mappings
{
    public class SalaMapping : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(s => s.Capacidade)
                .IsRequired();

            builder.ToTable("Salas");
        }
    }

}