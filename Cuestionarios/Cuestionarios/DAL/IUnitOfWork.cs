using Cuestionarios.DAL.EntityFramework;

namespace Cuestionarios.DAL
{
    interface IUnitOfWork
    {
        void Complete();

        IQuestionRepository QuestionRepository { get; }
    }
}
