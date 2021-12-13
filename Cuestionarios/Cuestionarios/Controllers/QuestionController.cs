using AutoMapper;
using Cuestionarios.DataAccessLayer;
using Cuestionarios.Domain;
using Cuestionarios.DTOs;
using Cuestionarios.Sources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cuestionarios.Controllers
{
    public class QuestionController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        //Save the questions
        public void LoadQuestions(string pSetName, string pDificulty, string pCategory, int pAmount)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSetName);
            int categoryNumber = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;
            List<Question> questionsList = source.GetQuestions(pDificulty, categoryNumber, pAmount).ToList();

            iUOfW.QuestionRepository.SaveQuestions(pSetName, questionsList);

            iUOfW.Complete();
        }

        //Get saved questions
        public IEnumerable<QuestionDTO> GetQuestions(string pSetName, string pDifficulty, string pCategory, int pAmount)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSetName);
            var questionsList = new List<Question>();

            if (source.DifficultyDictionary.ContainsValue(pDifficulty) && source.CategoryDictionary.ContainsValue(pCategory))
            {
                int difficulty = source.DifficultyDictionary.FirstOrDefault(x => x.Value == pDifficulty).Key;
                int category = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;
                questionsList = iUOfW.QuestionRepository.GetQuestions(pSetName, difficulty, category, pAmount).ToList();
            }
            else
            {
                throw new ArgumentException("One of the parameters entered is not valid");
            }

            List<QuestionDTO> result = new List<QuestionDTO>();

            foreach (var question in questionsList)
            {
                result.Add(Mapper.Map<Question, QuestionDTO>(question));
            }

            return result;
        }

        /// <summary>
        /// Get list of categories from questions in DB that correspond to a Set
        /// </summary>
        public IEnumerable<string> GetCategoriesOfSet(string pSetName)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSetName);
            var categoriesKeys = iUOfW.QuestionRepository.GetCategoriesOfSet(pSetName);
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
        public IEnumerable<string> GetDifficultiesOfCategory(string pSetName, string pCategory)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSetName);
            int category = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;
            IEnumerable<int> difficultiesKeys = iUOfW.QuestionRepository.GetDifficultiesOfCategory(pSetName, category).ToList();
            List<string> difficulties = new List<string>();
            foreach (int key in difficultiesKeys)
            {
                difficulties.Add(source.DifficultyDictionary.FirstOrDefault(x => x.Key == key).Value);
            }

            return difficulties;
        }

        //Get the maximum number of questions
        public int GetNumberQuestions(string pSetName, string pCategory, string pDifficulty)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(pSetName);
            int difficulty = source.DifficultyDictionary.FirstOrDefault(x => x.Value == pDifficulty).Key;
            int category = source.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;

            var numbersQuestions = iUOfW.QuestionRepository.GetMaxNumberQuestions(pSetName, difficulty, category);
            return numbersQuestions;
        }

    }
}
