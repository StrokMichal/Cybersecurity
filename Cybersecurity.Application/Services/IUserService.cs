using Cybersecurity.Application.User;
using Cybersecurity.Domain.Entities;


namespace Cybersecurity.Application.Services
{
    public interface IUserService
    {
        Task Create(UserDto userDto);
        Task<IEnumerable<UserDto>> GetAll();
        
    }
}