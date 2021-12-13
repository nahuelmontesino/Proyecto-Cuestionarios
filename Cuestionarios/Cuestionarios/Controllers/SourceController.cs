using Cuestionarios.Sources;
using System.Collections.Generic;

namespace Cuestionarios.Controllers
{
    public class SourceController
    {
        /// <summary>
        /// Get all categories of a source
        /// </summary>
        public IEnumerable<string> GetAllCategories(string name)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(name);
            return source.CategoryDictionary.Values;
        }

        /// <summary>
        /// Gets all the difficulties of a source
        /// </summary>
        public IEnumerable<string> GetAllDifficulties(string name)
        {
            IQuestionnaireSource source = SourceFactory.GetSourceByName(name);
            return source.DifficultyDictionary.Values;
        }
    }
}
