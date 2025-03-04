using Cybersecurity.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task Create(User user);
        Task<User?> GetByName(string name);
        Task<IEnumerable<User>> GetAll();

        User? FindUserByCredentials(string userName, string password);
    }
}
