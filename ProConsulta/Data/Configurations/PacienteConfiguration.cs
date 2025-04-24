using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Pacientes"); //Nome da tabela

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome) //buildando Nome
                .IsRequired(true) // é requerido (obrigatorio)
                .HasColumnType("VARCHAR(50)"); //tipo da coluna

            builder.Property(x => x.Documento) 
                .HasColumnType("NVARCHAR(11)");

            builder.Property(x => x.Email) 
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Celular) 
                .HasColumnType("NVARCHAR(11)");

            builder.HasIndex(x => x.Documento)
                .IsUnique(); // Garante que um unico paciente tenha 1 documento

            builder.HasMany(a => a.Agendamentos) //Paciente pode ter varios agendamentos
                .WithOne(p => p.Paciente) //esse paciente pertence a esse agendamento
                .HasForeignKey(p => p.PacienteId) 
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
