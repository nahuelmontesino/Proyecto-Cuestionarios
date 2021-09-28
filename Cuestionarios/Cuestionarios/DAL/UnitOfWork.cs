using Npgsql;
using System;

namespace Cuestionarios.DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly QuestionnaireDbContext iDbContext;

        public UnitOfWork(QuestionnaireDbContext pContext)
        {
            iDbContext = pContext ?? throw new ArgumentNullException(nameof(pContext));

            QuestionRepository = new QuestionRepository(this.iDbContext);
            SetRepository = new SetRepository(this.iDbContext);

        }

        public IQuestionRepository QuestionRepository { get; private set; }
        public SetRepository SetRepository { get; private set; }

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
