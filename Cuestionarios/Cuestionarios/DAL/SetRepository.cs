using Cuestionarios.Domain;
using Npgsql;
using System;
using System.Linq;

namespace Cuestionarios.DAL
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
    }
}
