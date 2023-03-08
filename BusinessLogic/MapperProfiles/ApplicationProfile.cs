using AutoMapper;
using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MapperProfiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Make, MakeDto>().ReverseMap();
            CreateMap<MakeDto, Make>().ReverseMap();

            CreateMap<Year, YearDto>().ReverseMap();
            CreateMap<YearDto, Year>().ReverseMap();

            CreateMap<TypeEngine, TypeEngineDto>().ReverseMap();
            CreateMap<TypeEngineDto, TypeEngine>().ReverseMap();

            CreateMap<Model, ModelDto>()
                .ForMember(m => m.Year, opt => opt.MapFrom(m => m.Year));
            CreateMap<ModelDto, Model>().ReverseMap();
            
            CreateMap<Engine, EngineDto>()
                .ForMember(e => e.TypeEngine, opt => opt.MapFrom(e => e.TypeEngine));
            CreateMap<EngineDto, Engine>().ReverseMap();

            CreateMap<Car, CarDto>()
                .ForMember(c => c.Make, opt => opt.MapFrom(c => c.Make))
                .ForMember(c => c.Model, opt => opt.MapFrom(c => c.Model))
                .ForMember(c => c.Engine, opt => opt.MapFrom(c => c.Engine));
            CreateMap<CarDto, Car>().ReverseMap();
        }
    }
}
