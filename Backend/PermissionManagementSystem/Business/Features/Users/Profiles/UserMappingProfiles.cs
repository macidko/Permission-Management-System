using AutoMapper;
using Business.Features.Users.Commands.Create;
using Business.Features.Users.Dtos;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Users.Profiles;

public class UserMappingProfiles : Profile
{
    public UserMappingProfiles()
    {
        CreateMap<User, CreateUserCommand>().ReverseMap();
        //.ForMember(i => i.UnitPrice, opt=> opt.Map(dto => dto.Price));
    }
}
