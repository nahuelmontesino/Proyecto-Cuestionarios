using Cuestionarios.Domain;
using Npgsql;
using System;
using System.Linq;

namespace Cuestionarios.DAL.EntityFramework
{
    public class SetRepository : Repository<Set, QuestionnaireDbContext>
    {
        public SetRepository(QuestionnaireDbContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Returns a set by the name parameter
        /// </summary>
        public Set GetSetByName(string pName)
        {
            try
            {
                return Get(set => set.Name == pName).Single();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Error trying to get set name: ", ex);
            }
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
