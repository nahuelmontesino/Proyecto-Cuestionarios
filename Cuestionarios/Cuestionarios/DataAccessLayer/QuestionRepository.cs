using Cuestionarios.Domain;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cuestionarios.DataAccessLayer
{
    public class QuestionRepository : Repository<Question, QuestionnaireDbContext>
    {
        private static readonly Random rng = new Random();
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

            catch (Exception ex)
                //questionsList.;
                throw new NpgsqlException("Error trying to get questions: ", ex);
            catch (Exception)
            {
                throw new NpgsqlException("Error trying to get questions");
            }

            foreach (Question question in questionsList)
            {
                Shuffle(question.Options); ;
            }

            return questionsList.Take(pAmount);
        }

        public int GetNumberQuestions(Set pSet, int pDifficulty, int pCategory)
        {
            int numberQuestions = new int();
            try
            {
                var number = Get(question => question.Set.Id == pSet.Id &&
                                            question.Difficulty == pDifficulty &&
                                            question.Category == pCategory);

                numberQuestions = number.Count();
       
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Error trying to get number of questions: ", ex);
            }



            return numberQuestions;
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

        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private string CleanString(string pSentence)
        {
            pSentence = pSentence.Replace("&amp;", "&");
            pSentence = pSentence.Replace("&quot;", "\"");
            pSentence = pSentence.Replace("&ldquo;", "`");
            pSentence = pSentence.Replace("&rdquo;", "´");
            pSentence = pSentence.Replace("&#039;", "'");
            pSentence = pSentence.Replace("&rsquo;", "'");
            pSentence = pSentence.Replace("&ouml;", "ö");
            pSentence = pSentence.Replace("&uuml;", "ü");
            pSentence = pSentence.Replace("&aacute;", "á");
            pSentence = pSentence.Replace("&eacute;", "é");
            pSentence = pSentence.Replace("&iacute;", "í");
            pSentence = pSentence.Replace("&oacute;", "ó");
            pSentence = pSentence.Replace("&uacute;", "ú");
            pSentence = pSentence.Replace("&ocirc;", "ô");

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

            return difficultiesKeys;
        }
    }
}
