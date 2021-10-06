using Npgsql;
using System;

namespace Cuestionarios.DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private QuestionnaireDbContext iDbContext = new QuestionnaireDbContext();
        private IQuestionRepository questionRepository;
        private SetRepository setRepository;

        public UnitOfWork()
        {
        }

        public IQuestionRepository QuestionRepository
        { 
            get
            {
                if(questionRepository == null)
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
