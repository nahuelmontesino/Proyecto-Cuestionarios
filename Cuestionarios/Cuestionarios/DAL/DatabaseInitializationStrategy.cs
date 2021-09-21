using System.Data.Entity;

namespace Cuestionarios.DAL
{
    class DatabaseInitializationStrategy: DropCreateDatabaseIfModelChanges<QuestionnaireDbContext>
    {
    }
}
