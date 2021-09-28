using System;

namespace Cuestionarios.Domain
{
    public class Session
    {
        public int Id { get; set; }
        public virtual double ScoreValue { get; set; }
        public virtual string Username { get; set; }
        public virtual User User { get; set; }
        public virtual double SecondsUsed { get; set; }
        public virtual DateTime DateOfScore { get; set; }
    }
}
