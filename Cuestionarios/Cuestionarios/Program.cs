using Cuestionarios.DAL;
using Cuestionarios.DAL.EntityFramework;
using Cuestionarios.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UnitOfWork iUOfW = new UnitOfWork(new QuestionnaireDbContext());

            var repo = new QuestionRepository(new QuestionnaireDbContext());
            iUOfW.QuestionRepository.SaveQuestions(source, "hard", "General Knowledge", 11, iUOfW);
            var list = repo.GetQuestions(1, 3, 9, 5);


            Console.ReadKey();
        }
    }
}
