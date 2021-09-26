using Cuestionarios.Entities;
using System.Collections.Generic;

namespace Cuestionarios.Source
{
    public interface ISource
    {
        string Name { get; }
        Dictionary<int, string> CategoryDictionary { get; }
        Dictionary<int, string> DifficultyDictionary { get; }
        List<Question> GetQuestions(string pDificulty, int pCategory, int pAmount);
    }
}
