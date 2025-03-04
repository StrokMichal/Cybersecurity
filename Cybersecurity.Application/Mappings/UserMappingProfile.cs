using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cybersecurity.Application.User;
using Cybersecurity.Domain.Entities;


namespace Cybersecurity.Application.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserDto, Domain.Entities.User>();
            CreateMap<Domain.Entities.User, UserDto>();
        }
    }
}
