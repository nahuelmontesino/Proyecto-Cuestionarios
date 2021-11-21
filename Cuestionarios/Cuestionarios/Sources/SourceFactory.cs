using System;

namespace Cuestionarios.Sources
{
   public static class SourceFactory
    {
        public static IQuestionnaireSource GetSourceByName(string name)
        {
            //Add the new sources here
            switch (name)
            {
                case "opentdb": return new OpendbSource();
                default:
                    throw new ArgumentException("Invalid source type");
            }
        }

    }
}
