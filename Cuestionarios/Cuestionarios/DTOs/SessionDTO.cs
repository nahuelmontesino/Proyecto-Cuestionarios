using System;

namespace Cuestionarios.DTOs
{
    public class SessionDTO
    {
        public double Score { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public double TotalTimeInSecond { get; set; }
    }
}
