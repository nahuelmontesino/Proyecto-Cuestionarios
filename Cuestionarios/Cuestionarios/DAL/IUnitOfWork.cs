using Cuestionarios.DAL.EntityFramework;

namespace Cuestionarios.DAL
{
    interface IUnitOfWork
    {
        void Complete();

        QuestionRepository QuestionRepository { get; }
    }
}
