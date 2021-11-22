using Cuestionarios.DataAccessLayer;
using Cuestionarios.Domain;
using System.Collections.Generic;


namespace Cuestionarios.Controllers
{

    public class SetController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public Set GetSetByName(string name)
        {
            return iUOfW.SetRepository.GetSetByName(name);
        }

        public IEnumerable<Set> GetAllSets()
        {
            return iUOfW.SetRepository.Get();
        }
    }
}
