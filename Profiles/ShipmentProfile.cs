using AutoMapper;
using FMS_API.Entities;
using FMS_API.Models;

namespace FMS_API.Profiles
{
    public class ShipmentProfile : Profile
    {
        public ShipmentProfile()
        {
            // source -> destination
            CreateMap<TC_OIM, VM_OIM>()
                .ForMember(dest => dest.F_RefNo, opt => opt.MapFrom(src => src.oim.F_RefNo))
                .ForMember(dest => dest.F_MBLNo, opt => opt.MapFrom(src => src.oim.F_MBLNo))
                .ForMember(dest => dest.F_HBLNo, opt => opt.MapFrom(src => src.oih.F_HBLNo))
                .ForMember(dest => dest.F_LoadingPort, opt => opt.MapFrom(src => src.oim.F_LoadingPort))
                .ForMember(dest => dest.F_ETD, opt => opt.MapFrom(src => src.oim.F_ETD))
                .ForMember(dest => dest.F_ETA, opt => opt.MapFrom(src => src.oim.F_ETA));
        }
    }
}
