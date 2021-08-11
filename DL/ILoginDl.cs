using Entities.Models;
using System.Threading.Tasks;

namespace DL
{
    public interface ILoginDl
    {
        Task<User> addUser(User user);
        Task<User> deleteUser(User user);
        Task<User> getUser(string password,string userName);
        Task<User> updateUser(User user);
    }
}