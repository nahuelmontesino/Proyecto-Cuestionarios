using System;

namespace Cuestionarios.Domain
{
    public class Session
    {
        public int Id { get; set; }
        public virtual double ScoreValue { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
