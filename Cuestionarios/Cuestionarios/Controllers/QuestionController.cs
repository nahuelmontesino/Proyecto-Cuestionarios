using Cuestionarios.DAL;
using Cuestionarios.Domain;
using Cuestionarios.Sources;
using System.Collections.Generic;
using System.Linq;

namespace Cuestionarios.Controllers
{
    public class QuestionController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public void LoadQuestions(Set pSet, string pDificulty, string pCategory, int pAmount)
        {
            ISource source = SourceFactory.GetSourceByName(pSet.Name);

            int categoryNumber = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;

            List<Question> questionsList = source.GetQuestions(pDificulty, categoryNumber, pAmount).ToList();

            iUOfW.QuestionRepository.SaveQuestions(pSet, questionsList);
        }

        public IEnumerable<Question> GetQuestions(Set pSet, int pDifficulty, int pCategory, int pAmount)
        {
            return iUOfW.QuestionRepository.GetQuestions(pSet, pDifficulty, pCategory, pAmount);
        }

        /// <summary>
        /// Get list of categories from questions in DB that correspond to a Set
        /// </summary>
        public IList<string> GetCategoriesOfSet(Set pSet)
        {
            return iUOfW.QuestionRepository.GetCategoriesOfSet(pSet);
        }

        /// <summary>
        /// Get list of difficulties from questions in DB that correspond to a Set and a category
        /// </summary>
        public IList<string> GetDifficultiesOfCategory(Set pSet, string pCategory)
        {
            ISource source = SourceFactory.GetSourceByName(pSet.Name);

            int category = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;

            IList<int> difficultiesKeys = iUOfW.QuestionRepository.GetDifficultiesOfCategory(pSet, category).ToList();

            IList<string> difficulties = new List<string>();

            foreach (int key in difficultiesKeys)
            {
                difficulties.Add(source.DifficultyDictionary.FirstOrDefault(x => x.Key == key).Value);
            }

            return difficulties;
        }

    }
}
