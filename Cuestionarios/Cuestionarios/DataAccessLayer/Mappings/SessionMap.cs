using Cuestionarios.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Cuestionarios.DataAccessLayer.Mappings
{
    class SessionMap : EntityTypeConfiguration<Session>
    {
        public SessionMap()
        {
            ToTable("Session");

            HasKey(b => b.Id)
                .Property(b => b.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasRequired(q => q.User)
                .WithMany(g => g.Sessions);

            Property(b => b.Score)
                .IsRequired()
                .HasColumnName("score");

            Property(b => b.TotalTime)
                .IsRequired()
                .HasColumnName("totalTime");

            Property(b => b.Date)
                .IsRequired()
                .HasColumnName("date");
        }
    }
}
