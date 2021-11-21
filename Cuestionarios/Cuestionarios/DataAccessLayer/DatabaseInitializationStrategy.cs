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

            //Adds the default admin user
            context.Users.Add(new User
            {
                Username = "admin",
                Password = "admin",
                Admin = true
            });

            //Adds the default admin user
            context.Users.Add(new User
            {
                Username = "user",
                Password = "user",
                Admin = false
            });

            context.SaveChanges();

            base.Seed(context);

        }
    }
}
