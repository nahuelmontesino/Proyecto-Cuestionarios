using Cuestionarios.Models.Domain;
using System;

namespace Cuestionarios.Models.DAL
{
    public class SessionRepository : Repository<Session, QuestionnaireDbContext>
    {
        

        public SessionRepository(QuestionnaireDbContext pContext) : base(pContext)
        {
            
        }
        public void SaveSession(User pUser, double pScoreValue, TimeSpan pTotalTime)
        {
            User user = iDbContext.Users.Find(pUser.Id);

            Session session = new Session
            {
                TotalTime = pTotalTime,
                ScoreValue = pScoreValue,
                User = user,
                Date = DateTime.Now
            };

            dbSet.Add(session);

        }
    }
}
