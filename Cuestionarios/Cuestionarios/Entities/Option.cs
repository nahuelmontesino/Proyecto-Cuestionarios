

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cuestionarios.Entities
{
    [Table("Option")]
    public class Option
    {
        [Key]
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool Correct { get; set; }
        public virtual int QuestionID { get; set; }
        public virtual Question Question { get; set; }
    }
}
