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
            UserController userController = new UserController();
            SetController setController = new SetController();
            QuestionController questionController = new QuestionController();
            SessionController sessionController = new SessionController();
            Application.Run(new Login(userController, setController, questionController, sessionController));
        }
    }
}
