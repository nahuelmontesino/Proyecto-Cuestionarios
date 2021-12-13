using System.Collections.Generic;

namespace Cuestionarios.Domain
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionSentence { get; set; }
        public int Difficulty { get; set; }
        public int Category { get; set; }
        public virtual IList<Option> Options { get; set; }
        public virtual Set Set { get; set; }
    }
}
