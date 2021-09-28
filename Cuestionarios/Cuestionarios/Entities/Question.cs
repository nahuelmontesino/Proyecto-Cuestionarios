using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cuestionarios.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionSentence { get; set; }
        public virtual int Difficulty { get; set; }
        public virtual int Category { get; set; }
        public virtual IList<Option> Options { get; set; }
        public virtual int SetID { get; set; }
    }
}
