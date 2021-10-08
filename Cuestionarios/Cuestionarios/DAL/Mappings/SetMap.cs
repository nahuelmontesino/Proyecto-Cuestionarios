using Cuestionarios.Domain;
using System.Data.Entity.ModelConfiguration;


namespace Cuestionarios.DAL.Mappings
{
    class SetMap: EntityTypeConfiguration<Set>
    {
        /// <summary>
        /// Maps Set Class to the database
        /// </summary>
        public SetMap()
        {
            ToTable("Set");

            HasKey(b => b.Id)
                .Property(b => b.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(b => b.Name)
                .IsRequired()
                .HasColumnName("name");

            //Maps the relation between Set and Question (One to Many)
            HasMany(b => b.Questions)
                .WithRequired()
                .HasForeignKey<int>(b => b.SetID)
                .WillCascadeOnDelete();
        }
    }
}
