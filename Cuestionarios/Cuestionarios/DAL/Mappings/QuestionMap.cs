using Cuestionarios.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Cuestionarios.DAL.EntityFramework.Mappings
{
    public class QuestionMap: EntityTypeConfiguration<Question>
    {
        /// <summary>
        /// Maps Question Class to the database
        /// </summary>
        public QuestionMap()
        {
            ToTable("Question");

            HasKey(b => b.Id)
                .Property(b => b.Id)
                .HasColumnName("id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(b => b.QuestionSentence)
                .IsRequired()
                .HasColumnName("question");

            Property(b => b.Difficulty)
                .IsRequired()
                .HasColumnName("dificulty");

            Property(b => b.Category)
                .IsRequired()
                .HasColumnName("category");

            //Maps the relation between Question and Option (One to Many)
            HasMany<Option>(b => b.Options)
                .WithRequired(b => b.Question)
                .HasForeignKey<int>(b => b.QuestionID)
                .WillCascadeOnDelete();
        }
    }
}
