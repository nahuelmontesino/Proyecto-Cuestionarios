using Cuestionarios.Domain;
using Cuestionarios.Sources;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cuestionarios.DAL
{
    public class QuestionRepository: Repository<Question, QuestionnaireDbContext>
    {

        public QuestionRepository(QuestionnaireDbContext pContext): base(pContext)
        {
        }

        public void SaveQuestions(Set set, string pDificulty, string pCategory, int pAmount)
        {
            ISource source = SourceFactory.GetSourceByName(set.Name);

            int categoryNumber = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;

            List<Question> questionsList = source.GetQuestions(pDificulty, categoryNumber, pAmount).ToList();

            try
            {
                foreach (Question question in questionsList)
                {
                    //Add the question to the DB
                    Set existing_set = iDbContext.Sets.Find(set.Id);
                    question.Set = existing_set;
                    iDbContext.Questions.Add(question);
                }

                iDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }
        }


        public IEnumerable<Question> GetQuestions(Set pSet, int pDifficulty, int pCategory, int pAmount)
        {
            List<Question> questionsList = new List<Question>();

            try
            {
                var query = Get(question => question.Set.Id == pSet.Id &&
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
