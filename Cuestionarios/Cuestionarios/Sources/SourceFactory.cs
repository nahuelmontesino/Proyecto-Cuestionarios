using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuestionarios.Sources
{
   public class SourceFactory
    {
        public ISource GetSourceByName(string name)
        {
            switch (name)
            {
                case "opentdb": return new OpendbSource();
                default:
                    throw new ArgumentException("Invalid type", "type");
            }
        }

        public IEnumerable<ISource> GetAllSources()
        {
            List<ISource> sources = new List<ISource>();
            var type_ = typeof(ISource);
            var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type_.IsAssignableFrom(p) && !p.IsInterface);

            foreach (var type in types)
            {
                var intanceClass = (ISource)Activator.CreateInstance(type);
                sources.Add(intanceClass);
            }

            return sources;


        }

    }
}
