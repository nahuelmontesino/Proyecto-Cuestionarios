using Cuestionarios.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Cuestionarios.Sources
{
    public interface ISource
    {
        string UrlBase { get; }
        string Name { get; }
        Dictionary<int, string> CategoryDictionary { get; }
        Dictionary<int, string> DifficultyDictionary { get; }
        List<Question> GetQuestions(string pDificulty, int pCategory, int pAmount);
    }
}
