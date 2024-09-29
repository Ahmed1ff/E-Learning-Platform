using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class UserRepository : IRepository<User>
    {
        private List<User> users = new();

        public void Add(User user) => users.Add(user);

        public IEnumerable<User> GetAll() => users;

        public User GetById(int id) => users.FirstOrDefault(u => u.UserId == id);
    }

}
