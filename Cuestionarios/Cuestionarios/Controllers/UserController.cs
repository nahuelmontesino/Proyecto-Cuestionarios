﻿using AutoMapper;
using Cuestionarios.DataAccessLayer;
using Cuestionarios.Domain;
using Cuestionarios.DTOs;
using System;
using System.Collections.Generic;

namespace Cuestionarios.Controllers
{
    public class UserController
    {
        private readonly UnitOfWork iUOfW = new UnitOfWork();

        public UserController() { }

        /// <summary>
        /// Get a user by name
        /// </summary>
        public UserDTO GetUserByName(string name)
        {
            var user = iUOfW.UserRepository.GetByUserName(name);

            return Mapper.Map<User, UserDTO>(user);
        }

        /// <summary>
        /// Add a user
        /// </summary>
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
