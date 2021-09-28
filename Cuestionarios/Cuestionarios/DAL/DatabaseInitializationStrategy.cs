using Cuestionarios.Domain;
using System.Data.Entity;

namespace Cuestionarios.DAL
{
    class DatabaseInitializationStrategy: DropCreateDatabaseAlways<QuestionnaireDbContext>
    {

        protected override void Seed(QuestionnaireDbContext context)
        {
            //Adds the default set of questions
            context.Sets.Add(new Set
            {
                Id = 1,
                Name = "opentdb"
            });

        }
    }
}
