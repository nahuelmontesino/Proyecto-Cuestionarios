using Cuestionarios.Entities;
using Cuestionarios.Source;
using System.Collections.Generic;
using System.Linq;


namespace Cuestionarios.DAL.EntityFramework
{
    class QuestionRepository: Repository<Question, QuestionnaireDbContext>, IQuestionRepository
    {

        public QuestionRepository(QuestionnaireDbContext pContext): base(pContext)
        {
        }

        public void SaveQuestions(ISource pSource, string pDificulty, string pCategory, int pAmount, UnitOfWork pUnitOfWork)
        {
            int categoryNumber = pSource.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;

            List<Question> questionsList = pSource.GetQuestions(pDificulty, categoryNumber, pAmount);


        }
    }
}
