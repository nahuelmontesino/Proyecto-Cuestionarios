using Cuestionarios.DAL;
using Cuestionarios.Domain;
using Cuestionarios.Sources;
using System.Collections.Generic;

namespace Cuestionarios.Controllers
{
    public class QuestionController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public void LoadQuestions(ISource pSource, string pDificulty, string pCategory, int pAmount)
        {
            iUOfW.QuestionRepository.SaveQuestions(pSource, pDificulty, pCategory, pAmount, iUOfW);
        }

        public IEnumerable<Question> GetQuestions(ISource pSource, int pDifficulty, int pCategory, int pAmount)
        {
            int set = iUOfW.SetRepository.GetSetByName(pSource.Name).Id;
            return iUOfW.QuestionRepository.GetQuestions(set, pDifficulty, pCategory, pAmount);
        }
    }
}
