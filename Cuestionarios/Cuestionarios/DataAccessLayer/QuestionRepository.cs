using Cuestionarios.Domain;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cuestionarios.DataAccessLayer
{
    public class QuestionRepository : Repository<Question, QuestionnaireDbContext>
    {
        //private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public QuestionRepository(QuestionnaireDbContext pContext) : base(pContext)
        {
        }

        public void SaveQuestions(Set set, IList<Question> pQuestionList)
        {
            try
            {
                foreach (Question question in pQuestionList)
                {
                    if (!IsAlreadySaved(question.QuestionSentence))
                    {
                        //Add the question to the DB
                        Set existing_set = iDbContext.Sets.Find(set.Id);
                        question.Set = existing_set;
                        dbSet.Add(question);
                    }
                }

                iDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw new NpgsqlException("Error trying to load questions");
            }
        }


        public IEnumerable<Question> GetQuestions(Set pSet, int pDifficulty, int pCategory, int pAmount)
        {
            var questionsList = new List<Question>();

            try
            {
                var query = Get(question => question.Set.Id == pSet.Id &&
                                            question.Difficulty == pDifficulty &&
                                            question.Category == pCategory);


                questionsList = query.ToList();

                if (questionsList.Count < pAmount)
                {
                    throw new InvalidOperationException("The number of available questions is less than requested");
                }

                //hacer un Shuffle(questionsList);
                questionsList.Take(pAmount);
            }
            catch (Exception)
            {
                throw new NpgsqlException("Error trying to get questions");
            }

            //foreach (Question question in questionsList)
            //{
            //    Shuffle(question.Options); ;
            //}

            return questionsList;
        }

        public IEnumerable<int> GetCategoriesOfSet(Set pSet)
        {

            IEnumerable<int> categoriesKeys = Get(q => q.Set.Id == pSet.Id).Select(q => q.Category).Distinct();

            return categoriesKeys;
        }

        public IEnumerable<int> GetDifficultiesOfCategory(Set pSet, int category)
        {
            IEnumerable<int> difficultiesKeys = Get(q => q.Set.Id == pSet.Id && q.Category == category)
                                                      .Select(q => q.Difficulty)
                                                      .Distinct();

            return difficultiesKeys;
        }

        /// <summary>
        /// Returns if the question is already in the database
        /// </summary>
        private bool IsAlreadySaved(string pQuestion)
        {
            IEnumerable<Question> questionsList = new List<Question>();
            questionsList = Get();

            Question result = questionsList.ToList().Find(s => s.QuestionSentence == pQuestion);

            return result != null;
        }
    }
}
