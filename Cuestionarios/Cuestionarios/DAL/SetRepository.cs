using Cuestionarios.Domain;
using Npgsql;
using System;

namespace Cuestionarios.DAL.EntityFramework
{
    public class SetRepository : Repository<Set, QuestionnaireDbContext>
    {
        public SetRepository(QuestionnaireDbContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Adds a question to the database
        /// </summary>
        public void AddQuestion(Question pQuestion)
        {
            try
            {
                iDbContext.Questions.Attach(pQuestion);
                iDbContext.Questions.Add(pQuestion);
                iDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Error trying to add questions: ", ex);
            }
        }
    }
}
