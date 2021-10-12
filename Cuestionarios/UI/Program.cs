using Cuestionarios.Controllers;
using System;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //SetController setController = new SetController();
            //QuestionController questController = new QuestionController();
            //Application.Run(new CreateGame(setController, questController));
            Application.Run(new Menu());
        }
    }
}
