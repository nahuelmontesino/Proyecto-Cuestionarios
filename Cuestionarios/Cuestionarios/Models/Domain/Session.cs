using System;

namespace Cuestionarios.Models.Domain
{
    public class Session
    {
        public int Id { get; set; }
        public virtual double ScoreValue { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual TimeSpan TotalTime { get; set; }
    }
}
