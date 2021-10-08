using Cuestionarios.Domain;

namespace Cuestionarios.DAL
{
    public class SessionRepository: Repository<Session, QuestionnaireDbContext>
    {
        public SessionRepository(QuestionnaireDbContext pContext) : base(pContext)
        {
        }
    }
}
