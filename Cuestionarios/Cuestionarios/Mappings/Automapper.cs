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
                cfg.CreateMap<Question, QuestionDTO>().ReverseMap();

                cfg.CreateMap<Set, SetDTO>().ReverseMap();

                cfg.CreateMap<User, UserDTO>();

                cfg.CreateMap<Session, SessionDTO>()
                .ForMember(dest => dest.TotalTimeInSecond, origin => origin.MapFrom(c => c.TotalTime.TotalSeconds))
                .ForMember(dest => dest.UserName, origin => origin.MapFrom(c => c.User.Username));
            });
        }
    }
}
