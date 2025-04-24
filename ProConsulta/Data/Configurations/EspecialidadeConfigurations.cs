using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class EspecialidadeConfigurations : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("Especialidade"); //Nome da tabela

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Descrição)
                .IsRequired(false)
                .HasColumnType("VARCHAR(150)");

            builder.HasMany(a => a.Medicos) //medico pode ter varios agendamentos
                .WithOne(p => p.Especialidade) //esse especialidade pertence a esse medico
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
