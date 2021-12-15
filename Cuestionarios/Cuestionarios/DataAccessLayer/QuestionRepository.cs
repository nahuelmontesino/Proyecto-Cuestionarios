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

        /// <summary>
        /// Save questions in the DB
        /// </summary>
        /// <param name="pSetName">Set to which the question belongs</param>
        /// <param name="pQuestionList"> List of questions </param>
        public void SaveQuestions(string pSetName, IList<Question> pQuestionList)
        {
            try
            {
                foreach (Question question in pQuestionList)
                {
                    if (!IsAlreadySaved(CleanString(question.QuestionSentence)))
                    {
                        //Add the question to the DB
                        Set existing_set = iDbContext.Sets.Where(set => set.Name == pSetName).FirstOrDefault();
                        question.Set = existing_set;
                        

                        //clear options
                        foreach (Option option in question.Options)
                        {
                            option.Answer = CleanString(option.Answer);
                        }

                        //clear questions
                        question.QuestionSentence = CleanString(question.QuestionSentence);

                        dbSet.Add(question);
                    }
                }
            }
            catch (Exception)
            {
                throw new NpgsqlException("Error trying to load questions");
            }
        }

        /// <summary>
        /// Check if there are any questions in DB
        /// </summary>
        public bool HaveAnyQuestion()
        {
            return dbSet.Any();
        }

        /// <summary>
        /// Remove questions from the DB
        /// </summary>

        public void RemoveQuestions(string pSetName, int pDifficulty, int pCategory, int pAmount)
        {


            try
            {
                var query = Get(question => question.Set.Name == pSetName &&
                                            question.Difficulty == pDifficulty &&
                                            question.Category == pCategory);


                var questionsList = query.Take(pAmount);

                foreach (var question in questionsList)
                {
                    Delete(question);
                }
            }

            catch (Exception)
            {
                throw new NpgsqlException("Error trying to remove questions");
            }

        }

        /// <summary>
        /// Get the questions from the DB
        /// </summary>

        public IEnumerable<Question> GetQuestions(string pSetName, int pDifficulty, int pCategory, int pAmount)
        {
            var questionsList = new List<Question>();

            try
            {
                var query = Get(question => question.Set.Name == pSetName &&
                                            question.Difficulty == pDifficulty &&
                                            question.Category == pCategory);


                questionsList = query.ToList();
            }

            catch (Exception)
            {
                throw new NpgsqlException("Error trying to get questions");
            }

            foreach (Question question in questionsList)
            {
                Shuffle(question.Options); ;
            }

            if (questionsList.Count < pAmount)
            {
                throw new InvalidOperationException("The number of available questions is less than requested");
            }

            return questionsList.Take(pAmount);
        }

        //Get the total number of questions from the DB
        public int GetMaxNumberQuestions(string pSetName, int pDifficulty, int pCategory)
        {
            int numberQuestions = 0;

            try
            {
                var number = Get(question => question.Set.Name == pSetName &&
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

        //Get the categories of a set
        public IEnumerable<int> GetCategoriesOfSet(string pSetName)
        {
            IEnumerable<int> categoriesKeys = Get(q => q.Set.Name == pSetName).Select(q => q.Category).Distinct();

            return categoriesKeys;
        }

        //Get the difficulties of a category
        public IEnumerable<int> GetDifficultiesOfCategory(string pSetName, int category)
        {
            IEnumerable<int> difficultiesKeys = Get(q => q.Set.Name == pSetName && q.Category == category)
                                                      .Select(q => q.Difficulty)
                                                      .Distinct();

            return difficultiesKeys;
        }

        /// <summary>
        /// Question list shuffle
        /// </summary>
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

        /// <summary>
        /// Clear sentence string to save in database
        /// </summary>
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

            return pSentence;
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
