using System.Collections.Generic;


namespace Cuestionarios.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public virtual IList<Session> Sessions { get; set; }
    }
}
