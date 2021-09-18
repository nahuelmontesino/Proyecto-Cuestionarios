using System.Data.Entity;

namespace Cuestionarios.DAL
{
    class DatabaseInitializationStrategy: DropCreateDatabaseAlways<QuestionnaireDbContext>
    {
    }
}
