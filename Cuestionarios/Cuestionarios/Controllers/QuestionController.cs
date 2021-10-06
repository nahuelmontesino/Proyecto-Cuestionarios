using Cuestionarios.DAL.EntityFramework;
using Cuestionarios.Domain;
using Cuestionarios.Sources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuestionarios.Controllers
{
    public class QuestionController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public void LoadQuestions(ISource pSource, string pDificulty, string pCategory, int pAmount)
        {
            iUOfW.QuestionRepository.SaveQuestions(pSource, pDificulty, pCategory, pAmount, iUOfW);
        }

        public List<Question> GetQuestions(ISource pSource, int pDifficulty, int pCategory, int pAmount)
        {
            int set = iUOfW.SetRepository.GetSetByName(pSource.Name).Id;
            return iUOfW.QuestionRepository.GetQuestions(set, pDifficulty, pCategory, pAmount);
        }
    }
}
