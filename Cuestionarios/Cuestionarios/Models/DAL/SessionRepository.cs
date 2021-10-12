using Cuestionarios.Models.Domain;
using System.Collections.Generic;
using Npgsql;
using System;
using System.Linq;

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
                Score = pScoreValue,
                User = user,
                Date = DateTime.Now
            };

            dbSet.Add(session);

        }

        public IEnumerable<Session> GetHighScores()
        {
            var sessionList = new List<Session>();

            try
            {
                var query = Get(null, session => session.OrderByDescending(x => x.ScoreValue));
                sessionList = query.Take(20).ToList();
            }
            catch (Exception ex)
            {
                throw new NpgsqlException("Error trying to get questions: ", ex);
            }

            return sessionList;
        }
    }
}
