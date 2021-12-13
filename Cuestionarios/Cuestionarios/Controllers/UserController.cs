using AutoMapper;
using Cuestionarios.DataAccessLayer;
using Cuestionarios.Domain;
using Cuestionarios.DTOs;
using System;
using System.Collections.Generic;

namespace Cuestionarios.Controllers
{
    public class UserController
    {
        readonly UnitOfWork iUOfW = new UnitOfWork();

        public UserController() { }

        //Get a user by name
        public UserDTO GetUserByName(string name)
        {
            var user = iUOfW.UserRepository.GetByUserName(name);

            return Mapper.Map<User, UserDTO>(user);
        }

        //Add a user
        public void AddUser(string pUsername, string pPassword, bool pAdmin = false)
        {
            if (iUOfW.UserRepository.GetByUserName(pUsername) == null)
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
