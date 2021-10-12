using Cuestionarios.Models.DAL;
using System.Collections.Generic;
using Cuestionarios.Models.Domain;

namespace Cuestionarios.Controllers
{
    public class SessionController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public IEnumerable<Session> GetHighScores()
        {
            return iUOfW.SessionRepository.GetHighScores();
        }

        
    }
}
