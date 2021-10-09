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

        public void SaveQuestions(Set set, IList<Question> pQuestionList)
        {
            try
            {
                foreach (Question question in pQuestionList)
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
            var questionsList = new List<Question>();

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

        public IList<string> GetCategoriesOfSet(Set pSet)
        {
            ISource source = SourceFactory.GetSourceByName(pSet.Name);

            IEnumerable<Question> listQuestions = Get(q => q.Set.Id == pSet.Id).ToList();

            List<int> categoriesKeys = listQuestions.Select(q => q.Category).Distinct().ToList();

            List<string> categories = new List<string>();

            foreach (int key in categoriesKeys)
            {
                categories.Add(source.CategoryDictionary.FirstOrDefault(x => x.Key == key).Value);
            }

            return categories;
        }

        public IEnumerable<int> GetDifficultiesOfCategory(Set pSet, int category)
        {
            IEnumerable<Question> listQuestionsOfCategory = Get(q => q.Set.Id == pSet.Id && q.Category == category);

            IEnumerable<int> difficultiesKeys = listQuestionsOfCategory.Select(q => q.Difficulty).Distinct();

            return difficultiesKeys;
        }
    }
}
