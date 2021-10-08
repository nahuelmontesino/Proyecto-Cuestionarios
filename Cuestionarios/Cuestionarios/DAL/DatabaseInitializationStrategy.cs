using Cuestionarios.Domain;
using Cuestionarios.Sources;
using System.Data.Entity;

namespace Cuestionarios.DAL
{
    class DatabaseInitializationStrategy: DropCreateDatabaseAlways<QuestionnaireDbContext>
    {

        protected override void Seed(QuestionnaireDbContext context)
        {
            var sourceFactory = new SourceFactory();

            foreach (var source in sourceFactory.GetAllSources())
            {
                context.Sets.Add(new Set
                {
                    Name = source.Name
                });
            }
           

        }
    }
}
