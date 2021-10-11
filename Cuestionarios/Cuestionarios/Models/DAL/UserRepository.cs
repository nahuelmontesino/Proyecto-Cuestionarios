using Cuestionarios.Models.Domain;
using Npgsql;
using System;
using System.Linq;


namespace Cuestionarios.Models.DAL
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
                return Get(user => user.Username == pUserName).Single();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }
        }
    }
}
