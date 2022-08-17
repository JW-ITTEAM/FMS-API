using AutoMapper;
using FMS_API.Entities;
using FMS_API.Models;

namespace FMS_API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // source -> destination
            CreateMap<T_USER, VM_USER>();
        }
    }
}
