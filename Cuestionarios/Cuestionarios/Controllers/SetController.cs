using Cuestionarios.Models.DAL;
using Cuestionarios.Models.Domain;
using System.Collections.Generic;


namespace Cuestionarios.Controllers
{

    public class SetController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();


        public IEnumerable<Set> GetAllSets()
        {
            return iUOfW.SetRepository.Get();
        }
    }
}
