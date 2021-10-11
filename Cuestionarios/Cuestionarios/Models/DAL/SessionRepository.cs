using Cuestionarios.Models.Domain;

namespace Cuestionarios.Models.DAL
{
    public class SessionRepository : Repository<Session, QuestionnaireDbContext>
    {
        public SessionRepository(QuestionnaireDbContext pContext) : base(pContext)
        {
        }
    }
}
