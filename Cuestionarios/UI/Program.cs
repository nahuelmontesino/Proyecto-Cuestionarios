﻿using Cuestionarios.Controllers;
using Cuestionarios.Mappings;
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
            var automapper = new Automapper();
            automapper.ConfigureAutomapper();
            UserController userController = new UserController();
            SetController setController = new SetController();
            QuestionController questionController = new QuestionController();
            SessionController sessionController = new SessionController();
            SourceController sourceController = new SourceController();
            Application.Run(new Login(userController, setController, questionController, sessionController, sourceController));
        }
    }
}
