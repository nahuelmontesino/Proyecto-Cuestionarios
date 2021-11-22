using Cuestionarios.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Cuestionarios.DataAccessLayer.Mappings
{
    class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");

            HasKey(b => b.Id)
                .Property(b => b.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(b => b.Username)
                .IsRequired()
                .HasColumnName("username");

            Property(b => b.Password)
                .IsRequired()
                .HasColumnName("password");

            Property(b => b.Admin)
                .IsRequired()
                .HasColumnName("isAdmin");

            HasMany(b => b.Sessions)
                .WithRequired(b => b.User)
                .WillCascadeOnDelete();
        }
    }
}
