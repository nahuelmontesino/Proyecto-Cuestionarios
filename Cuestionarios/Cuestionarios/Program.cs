using Cuestionarios.Controllers;
using Cuestionarios.DAL;
using Cuestionarios.Sources;
using System;
using System.Linq;

namespace Cuestionarios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var set = new SetController();
            var sets = set.GetAllSets();
            var set_ = sets.ToList().FirstOrDefault();
            UnitOfWork iUOfW = new UnitOfWork();
            var questionController = new QuestionController();
            var repo = new QuestionRepository(new QuestionnaireDbContext());
            questionController.LoadQuestions(set_, "hard", "General Knowledge", 11);
            var list = repo.GetQuestions(set_, 2, 9, 5);
            var difficulties = questionController.GetDifficultiesOfCategory(set_, "General Knowledge");



            Console.ReadKey();
        }
    }
}
