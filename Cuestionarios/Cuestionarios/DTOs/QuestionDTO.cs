using Cuestionarios.Domain;
using System.Collections.Generic;


namespace Cuestionarios.DTOs
{
    public class QuestionDTO
    {
        public string QuestionSentence { get; set; }
        public virtual int Difficulty { get; set; }
        public virtual int Category { get; set; }
        public virtual IList<Option> Options { get; set; }
    }
}
