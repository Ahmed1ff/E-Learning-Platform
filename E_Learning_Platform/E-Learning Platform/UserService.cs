using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning_Platform
{
    public class UserService
    {
        public event Action<string> UserRegistered;

        public void RegisterUser(User user)
        {
            user.Register();
            UserRegistered?.Invoke(user.Name);
        }
    }

}
