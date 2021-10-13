using Cuestionarios.Models.DAL;
using Cuestionarios.Models.Domain;
using System;
using System.Collections.Generic;

namespace Cuestionarios.Controllers
{
    public class UserController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public UserController() { }

        public User GetUserByName(string name)
        {
            return iUOfW.UserRepository.GetByUserName(name);
        }

        public void AddUser(string pUsername, string pPassword, bool pAdmin)
        {
            if (GetUserByName(pUsername) == null)
            {
                User usr = new User
                {
                    Username = pUsername,
                    Password = pPassword,
                    Admin = pAdmin,
                    Sessions = new List<Session>()
                };

                iUOfW.UserRepository.Add(usr);
                iUOfW.Complete();
            }
            else
            {
                throw new InvalidOperationException("There is already a user with that username");
            }
        }
    }
}
