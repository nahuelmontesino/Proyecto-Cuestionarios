using Cuestionarios.Models.DAL.Mappings;
using Cuestionarios.Models.Domain;
using System;
using System.Data.Entity;


namespace Cuestionarios.Models.DAL
{
    public class QuestionnaireDbContext : DbContext
    {
        /// <summary>
        /// Initialize the DB
        /// </summary>
        public QuestionnaireDbContext() : base(nameOrConnectionString: "Default")
        {
            // The customized initialization strategy of the DB is established.  
            Database.SetInitializer(new DatabaseInitializationStrategy());
            Database.Initialize(false);
        }

        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Set> Sets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            if (pModelBuilder == null)
            {
                throw new ArgumentNullException(nameof(pModelBuilder));
            }

            //Adds each entity map
            pModelBuilder.Configurations.Add(new OptionMap());
            pModelBuilder.Configurations.Add(new QuestionMap());
            pModelBuilder.Configurations.Add(new SetMap());
            pModelBuilder.Configurations.Add(new UserMap());
            pModelBuilder.Configurations.Add(new SessionMap());
            base.OnModelCreating(pModelBuilder);
        }

    }
}
