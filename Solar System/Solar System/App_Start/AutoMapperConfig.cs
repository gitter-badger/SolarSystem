using System;
using AutoMapper;
using Model.Models;
using Solar_System.Models;

namespace Solar_System
{
    public class AutoMapperConfig
    {
        public static void RegisterAutoMapperRules()
        {
            Mapper.CreateMap<SpaceObject, OrbitViewModel>()
                .ForMember(ovm => ovm.FocusParameter,
                    m => m.MapFrom(so => so.SemiMajorAxis * (1 - Math.Pow(so.Eccentricity, 2))))
                .ForMember(ovm => ovm.SemiMinorAxis,
                    m => m.MapFrom(so => so.SemiMajorAxis * Math.Sqrt(1 - Math.Pow(so.Eccentricity, 2))));
            Mapper.CreateMap<OrbitViewModel, SpaceObject>();

            Mapper.CreateMap<SpaceObject, SpaceObjectViewModel>();
            Mapper.CreateMap<SpaceObjectViewModel, SpaceObject>();
        }
    }
}