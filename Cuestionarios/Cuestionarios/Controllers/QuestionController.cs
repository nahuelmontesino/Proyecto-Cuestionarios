using Cuestionarios.Models.DAL;
using Cuestionarios.Models.Domain;
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
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSet.Name);
            int categoryNumber = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;
            List<Question> questionsList = source.GetQuestions(pDificulty, categoryNumber, pAmount).ToList();

            iUOfW.QuestionRepository.SaveQuestions(pSet, questionsList);
        }

        public IEnumerable<Question> GetQuestions(Set pSet,string pDifficulty, string pCategory, int pAmount)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSet.Name);
            int difficulty = source.DifficultyDictionary.FirstOrDefault(x => x.Value == pDifficulty).Key;
            int category = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;

            return iUOfW.QuestionRepository.GetQuestions(pSet, difficulty, category, pAmount);
        }

        /// <summary>
        /// Get list of categories from questions in DB that correspond to a Set
        /// </summary>
        public IEnumerable<string> GetCategoriesOfSet(Set pSet)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSet.Name);
            var categoriesKeys = iUOfW.QuestionRepository.GetCategoriesOfSet(pSet);
            List<string> categories = new List<string>();
            foreach (int key in categoriesKeys)
            {
                categories.Add(source.CategoryDictionary.FirstOrDefault(x => x.Key == key).Value);
            }

            return categories;
        }

        /// <summary>
        /// Get list of difficulties from questions in DB that correspond to a Set and a category
        /// </summary>
        public IEnumerable<string> GetDifficultiesOfCategory(Set pSet, string pCategory)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSet.Name);
            int category = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;
            IEnumerable<int> difficultiesKeys = iUOfW.QuestionRepository.GetDifficultiesOfCategory(pSet, category).ToList();
            List<string> difficulties = new List<string>();
            foreach (int key in difficultiesKeys)
            {
                difficulties.Add(source.DifficultyDictionary.FirstOrDefault(x => x.Key == key).Value);
            }

            return difficulties;
        }

        public int GetNumberQuestions(Set pSet, string pCategory, string pDifficulty)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSet.Name);
            int difficulty = source.DifficultyDictionary.FirstOrDefault(x => x.Value == pDifficulty).Key;
            int category = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;

            var numbersQuestions = iUOfW.QuestionRepository.GetNumberQuestions(pSet, difficulty, category);
            return numbersQuestions;
        }

    }
}
