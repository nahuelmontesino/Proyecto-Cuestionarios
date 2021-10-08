using Cuestionarios.Domain;
using Cuestionarios.Sources;
using System.Data.Entity;

namespace Cuestionarios.DAL
{
    class DatabaseInitializationStrategy: DropCreateDatabaseAlways<QuestionnaireDbContext>
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
