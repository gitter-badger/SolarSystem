using AutoMapper;
using Model.Models;
using Solar_System.Models;

namespace Solar_System
{
    public class AutoMapperConfig
    {
        public static void RegisterAutoMapperRules()
        {
            Mapper.CreateMap<SpaceObject, SpaceObjectViewModel>();
            Mapper.CreateMap<SpaceObjectViewModel, SpaceObject>();
        }
    }
}