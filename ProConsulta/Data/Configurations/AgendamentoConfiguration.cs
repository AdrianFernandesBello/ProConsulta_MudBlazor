using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class AgendamentoConfiguration : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamentos"); //Nome da tabela

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Observação)
                .IsRequired(true)
                .HasColumnType("VARCHAR(250)");

            builder.Property(x => x.PacienteId)
                .IsRequired(true);

            builder.Property(x => x.MedicoId)
                .IsRequired(true);

        }
    }
}
