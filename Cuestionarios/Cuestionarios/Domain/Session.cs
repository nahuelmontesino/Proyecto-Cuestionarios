using System;

namespace Cuestionarios.Domain
{
    public class Session
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public virtual User User { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual TimeSpan TotalTime { get; set; }
    }
}
