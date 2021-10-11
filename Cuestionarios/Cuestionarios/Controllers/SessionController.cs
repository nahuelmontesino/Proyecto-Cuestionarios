
using Cuestionarios.Models.DAL;
using Cuestionarios.Models.Domain;
using System;

namespace Cuestionarios.Controllers
{
    public class SessionController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public void SaveSession(User pUser, double pScoreValue, TimeSpan pTotalTime)
        {
            iUOfW.SessionRepository.SaveSession(pUser, pScoreValue, pTotalTime);
            iUOfW.Complete();
        }

    }

        
}
