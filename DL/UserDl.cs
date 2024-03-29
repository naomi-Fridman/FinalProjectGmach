﻿using DTO;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class UserDl : IUserDl
    {
        gmach277Context gmachContext;

        public UserDl(gmach277Context _gmachContext)
        {
            gmachContext = _gmachContext;
        }
        public User getUser(string password, string userName)
        {
            return gmachContext.User.Where(u => u.UserName == userName && u.Password == password).FirstOrDefault();
        }
        public async Task<User> getUserByIdentityNumber(int identityNumber)
        {
            return await gmachContext.User.Where(x => x.IdentityNumber == identityNumber).FirstOrDefaultAsync();
        }
        public User getUserByIdentity(int identity)
        {
            return gmachContext.User.Where(u => u.IdentityNumber == identity ).FirstOrDefault();
        }
        public async Task<User> getUserById(int userId)
        {
            return await gmachContext.User.Where(x => x.Id == userId).FirstOrDefaultAsync();
        }
        public async Task<int> addUser(User user)
        {
            gmachContext.User.Add(user);
            gmachContext.SaveChanges();
            User u = getUserByIdentity(user.IdentityNumber);
            return u.Id;
        }
        public async Task<User> updateUser(User user)
        {
            var userToUpdate = await gmachContext.User.Where(u => u.Id == user.Id).FirstOrDefaultAsync();
            gmachContext.Entry(userToUpdate).CurrentValues.SetValues(user);
            gmachContext.SaveChanges();
            return user;
        }
        public async Task<User> deleteUser(int userId)
        {
            User user;
            user = await getUserById(userId);
            gmachContext.User.Remove(user);
            gmachContext.SaveChangesAsync();
            return user;
        }
        public async Task<List<User>> getAllUsers(DTO_UserParams dTO_UserParams)
        {
            var users = await gmachContext.User.Where(
               user => (user.FirstName == dTO_UserParams.FirstName || dTO_UserParams.FirstName == null)
               && (user.LastName == dTO_UserParams.LastName || dTO_UserParams.LastName == null)
               && (user.Id == dTO_UserParams.Id || dTO_UserParams.Id == null)
               && (user.TelephoneNumber1 == dTO_UserParams.TelephoneNumber1 || dTO_UserParams.TelephoneNumber1 == null)
               && (user.TelephoneNumber2 == dTO_UserParams.TelephoneNumber2 || dTO_UserParams.TelephoneNumber2 == null)
               && (user.Address == dTO_UserParams.Address || dTO_UserParams.Address == null)
               && (user.City == dTO_UserParams.City || dTO_UserParams.City == null)
               && (user.Email == dTO_UserParams.Email || dTO_UserParams.Email == null)
               && (user.IdentityNumber == dTO_UserParams.IdentityNumber || dTO_UserParams.IdentityNumber == null)).ToListAsync();
            return users;
        }
        public List<string> getAddress(string str)
        {
            List<string> addres = new List<string>();
            string url = "https://maps.googleapis.com/maps/api/place/autocomplete/json?input=" + str + "&types=geocode&language=iw&key=AIzaSyAwLbz_DgWGXlxplEN6A0nm0wKrbCd60Kc";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string responseFromServer = reader.ReadToEnd();
            JObject results = JObject.Parse(responseFromServer);
            for (int i = 0; i < results.First.First.Count(); i++)
            {
                addres.Add(Convert.ToString(results.First.First[i].First.First));
            }
            return addres;
        }
    }
}
