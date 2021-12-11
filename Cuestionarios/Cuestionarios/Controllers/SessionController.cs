using System.Collections.Generic;
using Cuestionarios.DataAccessLayer;
using System;
using Cuestionarios.Sources;
using Cuestionarios.Domain;
using System.Linq;
using Cuestionarios.DTOs;

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

        public double GetScore(SetDTO pSet, int correctAnswers, int totalQuestions, string difficulty, double time)
        {
            int difficultyFactor, timeFactor;

            var source = SourceFactory.GetSourceByName(pSet.Name);
            int difficultyKey = source.DifficultyDictionary.FirstOrDefault(x => x.Value == difficulty).Key;

            difficultyFactor = source.GetDifficultyFactor(difficultyKey);
            timeFactor = source.GetTimeFactor(time);

            return ((double)correctAnswers / (double)totalQuestions) * (double)difficultyFactor * (double)timeFactor;
        }
    }        
}
