namespace Cuestionarios.Domain
{
    public class Option
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool Correct { get; set; }
        public virtual int QuestionID { get; set; }
        public virtual Question Question { get; set; }
    }
}
