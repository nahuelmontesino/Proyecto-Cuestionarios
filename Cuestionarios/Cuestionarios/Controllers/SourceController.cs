﻿using Cuestionarios.Sources;
using System.Collections.Generic;

namespace Cuestionarios.Controllers
{
    public class SourceController
    {
        public IEnumerable<string> GetAllCategories(string name)
        {
            ISource source = SourceFactory.GetSourceByName(name);
            return source.CategoryDictionary.Values;
        }

        public IEnumerable<string> GetAllDifficulties(string name)
        {
            ISource source = SourceFactory.GetSourceByName(name);
            return source.DifficultyDictionary.Values;
        }
    }
}