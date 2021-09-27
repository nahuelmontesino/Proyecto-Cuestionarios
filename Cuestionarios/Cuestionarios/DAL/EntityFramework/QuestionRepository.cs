using Cuestionarios.Entities;
using Cuestionarios.Source;
using Npgsql;
using System;
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

        public List<Question> GetQuestions(int pSet, int pDifficulty, int pCategory, int pAmount)
        {
            List<Question> questionsList = new List<Question>();

            try
            {
                var query = Get(question => question.SetID == pSet &&
                                            question.Difficulty == pDifficulty &&
                                            question.Category == pCategory);


                questionsList = query.ToList();

                if (questionsList.Count < pAmount)
                {
                    throw new InvalidOperationException();
                }

                //hacer un Shuffle(questionsList);
                questionsList.Take(pAmount);
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Error trying to get questions: ", ex);
            }

            //foreach (Question question in questionsList)
            //{
            //    Shuffle(question.Options); ;
            //}

            return questionsList;
        }
    }
}
