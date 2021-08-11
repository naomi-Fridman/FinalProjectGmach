

using DTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IUserDl
    {
        Task<int> addUser(User user);
        Task<User> deleteUser(int userId);
        User getUser(string password, string userName);
        Task<User> updateUser(User user);
        Task<List<User>> getAllUsers(DTO_UserParams dTO_UserParams);
        Task<User> getUserByIdentityNumber(int identityNumber);
        User getUserByIdentity(int identityNumber);
        Task<User> getUserById(int userId);
        List<string> getAddress(string str);

    }
}

