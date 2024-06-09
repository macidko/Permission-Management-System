using AutoMapper;
using Business.Abstract;
using Business.Features.Users.Dtos;
using Core.CrossCuttingConcerns.Types;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class UserManager : IUserService
{
    //private readonly IUserRepository _userRepository;
    //private readonly IMapper _mapper;

    //public UserManager(IUserRepository userRepository, IMapper mapper)
    //{
    //    _userRepository = userRepository;
    //    _mapper = mapper;
    //}

    //public async Task Add(AddUserRequest dto)
    //{
    //    if (dto == null)
    //    {
    //        throw new BusinessException("Kullanıcı boş olamaz");
    //    }

    //    User? userWithSameUsername = await _userRepository.GetAsync(u => u.Username == dto.Username);

    //    if (userWithSameUsername is not null)
    //    {
    //        throw new System.Exception("Kullanıcı adı alınmış.");
    //    }

    //    User user = _mapper.Map<User>(dto);
    //    await _userRepository.AddAsync(user);
    //}

    //public async void Delete(int id)
    //{
    //    User? userToDelete = await _userRepository.GetAsync(x => x.Id == id);
    //    throw new NotImplementedException();
    //}

    //public async Task<List<ListUserResponse>> GetAll()
    //{
    //    List<User> users = await _userRepository.GetListAsync();
    //    List<ListUserResponse> response = _mapper.Map<List<ListUserResponse>>(users);
    //    return response;
    //}

    //public User GetById(int id)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Update(User user)
    //{
    //    throw new NotImplementedException();
    //}
}
