using AutoMapper;
using MealSystem.DTO;
using MealSystem.Models;

namespace MealSystem.Commons.Config
{
    public class MapperProfiles : Profile
    {

        public MapperProfiles() 
        {
            CreateMap<Ticket, TicketDto>().ReverseMap();
        } 
    }
}
