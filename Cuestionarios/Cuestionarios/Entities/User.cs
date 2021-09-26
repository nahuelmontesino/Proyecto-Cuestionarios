using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuestionarios.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public virtual IList<Session> Sessions { get; set; }
    }
}
