namespace Cuestionarios.DataAccessLayer
{
    interface IUnitOfWork
    {
        void Complete();

        QuestionRepository QuestionRepository { get; }

        SetRepository SetRepository { get; }

        SessionRepository SessionRepository { get; }
    }
}
