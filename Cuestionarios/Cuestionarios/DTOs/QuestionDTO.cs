using Cuestionarios.Domain;
using System.Collections.Generic;


namespace Cuestionarios.DTOs
{
    public class QuestionDTO
    {
        public string QuestionSentence { get; set; }
        public int Difficulty { get; set; }
        public int Category { get; set; }
        public IList<OptionDTO> Options { get; set; }
    }
}
