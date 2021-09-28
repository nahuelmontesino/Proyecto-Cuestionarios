using Cuestionarios.Entities;
using Cuestionarios.Source;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Cuestionarios.DAL.EntityFramework
{
    public class QuestionRepository: Repository<Question, QuestionnaireDbContext>, IQuestionRepository
    {

        public QuestionRepository(QuestionnaireDbContext pContext): base(pContext)
        {
        }

        public void SaveQuestions(ISource pSource, string pDificulty, string pCategory, int pAmount, UnitOfWork pUnitOfWork)
        {
            int categoryNumber = pSource.CategoryDictionary.FirstOrDefault(x => x.Value == pCategory).Key;

            List<Question> questionsList = pSource.GetQuestions(pDificulty, categoryNumber, pAmount);

            try
            {
                foreach (Question question in questionsList)
                {

                        //Put the options in a separete list and delete them from the question
                        IList<Option> optionsList = new List<Option>();
                        foreach (Option opt in question.Options)
                        {
                            optionsList.Add(opt);
                        }
                        question.Options.Clear();

     

                        //Add the question to the DB
                        question.SetID = 1;
                        iDbContext.Question.Add(question);
                        pUnitOfWork.SetRepository.AddQuestion(question);

                        //Add each option to the DB
                        foreach (Option option in optionsList)
                        {
                            option.Answer = option.Answer;
                            option.Question = question;
                            option.QuestionID = question.Id;
                            AddOption(option);
                        }
                    
                }

                iDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException(ex.ToString());
            }
        }

        /// <summary>
        /// Adds an option related to that question
        /// </summary>
        public void AddOption(Option pOption)
        {
            try
            {
                iDbContext.Options.Attach(pOption);
                iDbContext.Options.Add(pOption);
                iDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Error trying to add new options: ", ex);
            }
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
