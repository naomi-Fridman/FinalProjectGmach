﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    
    public class LoginDl : ILoginDl
    {
        gmach277Context gmachContext;
        public LoginDl(gmach277Context _gmachContext)
        {
            gmachContext = _gmachContext;

        }
        public async Task<User> getUser(string password, string userName)
        {
            return await gmachContext.User.Where(u => u.Password == password && u.UserName == userName).FirstOrDefaultAsync();
        }
        public async Task<User> addUser(User user)
        {
            gmachContext.User.Add(user);
            await gmachContext.SaveChangesAsync();
            return user;
        }
        public async Task<User> updateUser(User user)
        {
            var userToUpdate = gmachContext.User.Find(user.Id);
            if (userToUpdate == null)
            {
                return null;
            }
            gmachContext.Entry(userToUpdate).CurrentValues.SetValues(user);
            await gmachContext.SaveChangesAsync();
            return user;
        }
        public async Task<User> deleteUser(User user)
        {
            gmachContext.User.Remove(user);
            await gmachContext.SaveChangesAsync();
            return user;
        }
    }
}
