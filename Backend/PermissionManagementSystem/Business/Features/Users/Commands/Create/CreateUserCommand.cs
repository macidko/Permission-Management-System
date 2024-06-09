using AutoMapper;
using Core.CrossCuttingConcerns.Types;
using DataAccess.Abstract;
using Entities.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Features.Users.Commands.Create;

public class CreateUserCommand : IRequest
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public class CreateUSerCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUSerCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            if (request.Username == null)
            {
                throw new BusinessException("Kullanıcı adı boş olamaz");
            }
            User? userWithSameName = await _userRepository.GetAsync(u => u.Username == request.Username);
            if (userWithSameName == null)
            {
                throw new System.Exception("Kullanıcı adı alınmış");
            }

            User user = _mapper.Map<User>(request);
            await _userRepository.AddAsync(user);
        }
    }
}
