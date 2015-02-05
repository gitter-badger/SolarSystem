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
            const int scale = 1000;

            Mapper.CreateMap<SpaceObject, OrbitViewModel>()
                .ForMember(ovm => ovm.SemiMajorAxis, m => m.MapFrom(so => so.SemiMajorAxis/scale))
                .ForMember(ovm => ovm.Perihelion, m => m.MapFrom(so => so.Perihelion/scale))
                .ForMember(ovm => ovm.Aphelion, m => m.MapFrom(so => so.Aphelion/scale))
                .ForMember(ovm => ovm.FocusParameter,
                    m => m.MapFrom(so => so.SemiMajorAxis*(1 - Math.Pow(so.Eccentricity, 2))))
                .ForMember(ovm => ovm.SemiMinorAxis,
                    m => m.MapFrom(so => so.SemiMajorAxis*Math.Sqrt(1 - Math.Pow(so.Eccentricity, 2))/scale))
                .ForMember(ovm => ovm.PrimaryDiameter, m => m.MapFrom(so => so.Primary.Radius*2));
            Mapper.CreateMap<OrbitViewModel, SpaceObject>();

            Mapper.CreateMap<SpaceObject, SpaceObjectViewModel>()
                .ForMember(sovm => sovm.Orbit, m => m.MapFrom(so => Mapper.Map<SpaceObject, OrbitViewModel>(so)))
                .ForMember(sovm => sovm.Diameter, m => m.MapFrom(so => so.Radius * 2));
            Mapper.CreateMap<SpaceObjectViewModel, SpaceObject>();
        }
    }
}