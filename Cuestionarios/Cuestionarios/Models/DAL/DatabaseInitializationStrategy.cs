using Cuestionarios.Models.Domain;
using System.Data.Entity;

namespace Cuestionarios.Models.DAL
{
    class DatabaseInitializationStrategy : DropCreateDatabaseAlways<QuestionnaireDbContext>
    {

        protected override void Seed(QuestionnaireDbContext context)
        {
            //Initialize sets with available sources
            context.Sets.Add(new Set
            {
                Name = "opentdb"
            });

        }
    }
}
