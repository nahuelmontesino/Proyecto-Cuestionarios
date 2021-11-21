using Npgsql;
using System;

namespace Cuestionarios.Models.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private QuestionnaireDbContext iDbContext = new QuestionnaireDbContext();
        private QuestionRepository questionRepository;
        private SetRepository setRepository;
        private SessionRepository sessionRepository;
        private UserRepository userRepository;

        public UnitOfWork()
        {
        }

        public QuestionRepository QuestionRepository
        {
            get
            {
                if (questionRepository == null)
                {
                    questionRepository = new QuestionRepository(iDbContext);
                }

                return questionRepository;
            }
        }
        public SetRepository SetRepository
        {
            get
            {
                if (setRepository == null)
                {
                    setRepository = new SetRepository(iDbContext);
                }

                return setRepository;
            }
        }

        public SessionRepository SessionRepository
        {
            get
            {
                if (sessionRepository == null)
                {
                    sessionRepository = new SessionRepository(iDbContext);
                }

                return sessionRepository;
            }
        }

        public UserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(iDbContext);
                }

                return userRepository;
            }
        }


        /// <summary>
        /// Persist the changes
        /// </summary>
        public void Complete()
        {
            try
            {
                iDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Coudn't save changes to the database: ", ex);
            }
        }

    }

}
