using System.Collections.Generic;

namespace Cuestionarios.Domain
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionSentence { get; set; }
        public virtual int Difficulty { get; set; }
        public virtual int Category { get; set; }
        public virtual IList<Option> Options { get; set; }
        public virtual Set Set { get; set; }
    }
}
