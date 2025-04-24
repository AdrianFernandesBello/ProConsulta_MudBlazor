using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class MedicoConfigurations : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medicos"); //Nome da tabela

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome) 
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)"); 

            builder.Property(x => x.Documento)
                .IsRequired()
                .HasColumnType("NVARCHAR(11)");

            builder.Property(x => x.Crm)
                .IsRequired()
                .HasColumnType("NVARCHAR(8)");

            builder.Property(x => x.Celular)
                .IsRequired()
                .HasColumnType("NVARCHAR(11)");

            builder.Property(x => x.EspecialidadeId)
                .IsRequired();

            builder.HasIndex(x => x.Documento)
                .IsUnique();

            builder.HasMany(a => a.Agendamentos) //medico pode ter varios agendamentos
                .WithOne(p => p.Medico) //esse medico pertence a esse agendamento
                .HasForeignKey(p => p.MedicoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
