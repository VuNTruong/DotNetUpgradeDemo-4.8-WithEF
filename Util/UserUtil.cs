using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class UserUtil
    {
        public async Task CreateNewUser(User user) 
        {
            using (var context = new EFContext())
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
            }
        }

        public async Task<User> GetSingleUserByName(string userName)
        {
            using (var context = new EFContext())
            {
                return await context.Users.Where(x => x.NAME == userName).SingleOrDefaultAsync();
            }
        }

        public async Task<List<User>> GetMultipleUsersByName(string userName)
        {
            using (var context = new EFContext())
            {
                return await context.Users.Where(x => x.NAME == userName).ToListAsync();
            }
        }

        public async Task<List<User>> GetAllUsersInDatabase()
        {
            using (var context = new EFContext())
            {
                return await context.Users.ToListAsync();
            }
        }
    }
}
