using System.Collections.Generic;
using Cuestionarios.Models.DAL;
using Cuestionarios.Models.Domain;
using System;

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

    }

        
}
