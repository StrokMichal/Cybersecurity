using Cybersecurity.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity.Infrastructure.Seeders
{
    public class UserSeeder
    {
        private readonly UserDbContext _dbContext;

        public UserSeeder(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Users.Any())
                {
                    var Admin = new Domain.Entities.User()
                    {
                        UserName = "Admin",
                        UserEmail = "email@domain.com",
                        Password = "admin1",
                        IsAdmin = true
                    };

                    _dbContext.Users.Add(Admin);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
