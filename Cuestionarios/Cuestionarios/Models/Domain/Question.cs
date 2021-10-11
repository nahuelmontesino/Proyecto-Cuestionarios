using System.Collections.Generic;

namespace Cuestionarios.Models.Domain
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionSentence { get; set; }
        public virtual int Difficulty { get; set; }
        public virtual int Category { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public virtual Set Set { get; set; }
    }
}
