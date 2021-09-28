
using System.Collections.Generic;

namespace Cuestionarios.Domain
{
    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<Question> Questions { get; set; }
    }
}
