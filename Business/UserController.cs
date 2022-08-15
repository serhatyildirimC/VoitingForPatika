using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserController
    {
        InMemory inMemory = new InMemory();

        public bool Controller(string UserName,string Password)
        {
           User user = inMemory.Get(UserName);

            if (user.Password == Password)
            {
                return true;
            }
            else return false;
                  
        }
        public bool AddUser(string UserName,string PassWord)
        {
            int i = 0;  
            List<User> users = inMemory.GetUsers();
           foreach(User user in users)
            {
                if (user.UserName == UserName)
                {
                    i++;
                }
            }
           if (i == 0)
            {
                return false;
            }
           else
            {
                User user = new User { Id = users.Count+1, UserName = UserName, Password = PassWord } ;
                inMemory.Add(user);
                return true;
            }

        }
    }
}
