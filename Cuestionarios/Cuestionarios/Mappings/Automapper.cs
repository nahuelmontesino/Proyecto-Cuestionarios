using AutoMapper;
using Cuestionarios.Domain;
using Cuestionarios.DTOs;

namespace Cuestionarios.Mappings
{
    public class Automapper
    {
        public Automapper()
        {
        }

        //Crea los mapeos necesarios
        public void ConfigureAutomapper()
        {

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Question, QuestionDTO>();

                cfg.CreateMap<Set, SetDTO>();

                cfg.CreateMap<SetDTO, Set>();
            });
        }
    }
}
