using System.Collections.Generic;
using Cuestionarios.DataAccessLayer;
using System;
using Cuestionarios.Sources;
using Cuestionarios.Domain;

namespace Cuestionarios.Controllers
{
    public class SessionController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public IEnumerable<Session> GetHighScores()
        {
            return iUOfW.SessionRepository.GetHighScores();
        }


        public void SaveSession(User pUser, double pScoreValue, TimeSpan pTotalTime)
        {
            iUOfW.SessionRepository.SaveSession(pUser, pScoreValue, pTotalTime);
            iUOfW.Complete();
        }

        public double getScore(IQuestionnaireSource qSource, int correctAnswers, int totalQuestions, int difficulty, double time)
        {
            int difficultyFactor, timeFactor;

            difficultyFactor = qSource.GetDifficultyFactor(difficulty);
            timeFactor = qSource.GetTimeFactor(time);

            return (((double)correctAnswers / (double)totalQuestions) * (double)difficultyFactor * (double)timeFactor);
        }
    }        
}
