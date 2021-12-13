using Cuestionarios.Sources;
using System.Collections.Generic;

namespace Cuestionarios.Controllers
{
    public class SourceController
    {
        //Get all categories of a source
        public IEnumerable<string> GetAllCategories(string name)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(name);
            return source.CategoryDictionary.Values;
        }

        //Gets all the difficulties of a source
        public IEnumerable<string> GetAllDifficulties(string name)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(name);
            return source.DifficultyDictionary.Values;
        }
    }
}
