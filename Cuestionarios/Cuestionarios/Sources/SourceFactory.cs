using System;
using System.Collections.Generic;
using System.Linq;

namespace Cuestionarios.Sources
{
   public class SourceFactory
    {
        public ISource GetSourceByName(string name)
        {
            //Add the new sources here
            switch (name)
            {
                case "opentdb": return new OpendbSource();
                default:
                    throw new ArgumentException("Invalid type", "type");
            }
        }

    }
}
