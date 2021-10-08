using Cuestionarios.DAL;
using Cuestionarios.DAL.EntityFramework;
using Cuestionarios.Sources;
using System;

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
            ISource source = new OpendbSource();
            UnitOfWork iUOfW = new UnitOfWork();

            var repo = new QuestionRepository(new QuestionnaireDbContext());
            iUOfW.QuestionRepository.SaveQuestions(source, "hard", "General Knowledge", 11, iUOfW);
            var list = repo.GetQuestions(1, 2, 9, 5);


            Console.ReadKey();
        }
    }
}
