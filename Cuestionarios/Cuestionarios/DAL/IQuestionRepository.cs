using Cuestionarios.Domain;
using Cuestionarios.Sources;


namespace Cuestionarios.DAL.EntityFramework
{
    public interface IQuestionRepository : IRepository<Question>
    {
        void SaveQuestions(ISource pSource, string pDificulty, string pCategory, int pAmount, UnitOfWork pUnitOfWork);
    }
}
