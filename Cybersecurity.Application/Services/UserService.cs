using AutoMapper;
using Cybersecurity.Application.User;
using Cybersecurity.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cybersecurity.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task Create(UserDto userDto)
        {
            var user = this.mapper.Map<Domain.Entities.User>(userDto);

            await this.userRepository.Create(user);
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var users = await this.userRepository.GetAll();
            var dtos = this.mapper.Map<IEnumerable<UserDto>>(users);

            return dtos;
        }
    }
}
