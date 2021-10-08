using Cuestionarios.DAL;
using Cuestionarios.Domain;
using Cuestionarios.Sources;
using System.Collections.Generic;

namespace Cuestionarios.Controllers
{
    public class QuestionController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public void LoadQuestions(Set pSet, string pDificulty, string pCategory, int pAmount)
        {
            iUOfW.QuestionRepository.SaveQuestions(pSet, pDificulty, pCategory, pAmount);
        }

        public IEnumerable<Question> GetQuestions(Set pSet, int pDifficulty, int pCategory, int pAmount)
        {
            return iUOfW.QuestionRepository.GetQuestions(pSet, pDifficulty, pCategory, pAmount);
        }
    }
}
