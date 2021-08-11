using DTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IUserBl
    {
        Task<User> getUserByIdentityNumber(int identityNumber);
        User getUserByIdentity(int identityNumber);
        Task<int> addUser(User user);
        Task<User> deleteUser(int userId);
        User getUser(string password, string userName);
        Task<User> updateuser(User user);
        Task<List<User>> getAllUsers(DTO_UserParams dTO_UserParams);
        Task<User> getUserById(int userId);
        List<string> getAddress(string str);


    }
}
