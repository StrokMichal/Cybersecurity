using Cybersecurity.Domain.Entities;
using Cybersecurity.Domain.Interfaces;
using Cybersecurity.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Collections.Specialized.BitVector32;


namespace Cybersecurity.Infrastructure.Repositories
{
    class UserRepository : IUserRepository
    {
        private readonly UserDbContext dbContext;

        public UserRepository(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task Create(User user)
        {
            user.Password = "wygenerowanehaslo";
            dbContext.Add(user);
            await dbContext.SaveChangesAsync();
        }
        public User? FindUserByCredentials(string userName, string password)
        {
            var options = new DbContextOptionsBuilder<UserDbContext>()
                .UseSqlServer("Cybersecurity") 
                .Options;
            var test = dbContext.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
            return test;

        }

        public async Task<IEnumerable<User>> GetAll()
        => await this.dbContext.Users.ToListAsync();

        public Task<User?> GetByName(string name)
        => this.dbContext.Users.FirstOrDefaultAsync(cw => cw.UserName.ToLower() == name.ToLower());
    }
}
