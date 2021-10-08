using Cuestionarios.DAL;
using Cuestionarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
