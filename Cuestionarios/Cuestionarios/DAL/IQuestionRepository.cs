using Cuestionarios.Domain;
using Cuestionarios.Sources;
using System.Collections.Generic;

namespace Cuestionarios.DAL.EntityFramework
{
    public interface IQuestionRepository : IRepository<Question>
    {
        void SaveQuestions(ISource pSource, string pDificulty, string pCategory, int pAmount, UnitOfWork pUnitOfWork);
        List<Question> GetQuestions(int pSet, int pDificulty, int pCategory, int pAmount);
    }
}
