using Cuestionarios.Domain;
using System.Data.Entity;

namespace Cuestionarios.DataAccessLayer
{
    class DatabaseInitializationStrategy : CreateDatabaseIfNotExists<QuestionnaireDbContext>
    {
        protected override void Seed(QuestionnaireDbContext context)
        {
            //Initialize sets with available sources
            context.Sets.Add(new Set
            {
                Name = "opentdb"
            });

            //Adds the default admin user
            context.Users.Add(new User
            {
                Username = "admin",
                Password = "admin",
                Admin = true
            });

            //Adds the default user
            context.Users.Add(new User
            {
                Username = "user",
                Password = "user",
                Admin = false
            });

            context.SaveChanges();
        }
    }
}
