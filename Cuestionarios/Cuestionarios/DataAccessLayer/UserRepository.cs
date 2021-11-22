using Cuestionarios.Domain;
using Npgsql;
using System;
using System.Linq;


namespace Cuestionarios.DataAccessLayer
{
    public class UserRepository: Repository<User, QuestionnaireDbContext>
    {
        public UserRepository(QuestionnaireDbContext pContext) : base(pContext)
        {
        }

        /// <summary>
        /// Gets User by username
        /// </summary>
        public User GetByUserName(string pUserName)
        {
            try
            {
                return Get(user => user.Username == pUserName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Error trying to get user", ex);
            }             
        }
    }
}
