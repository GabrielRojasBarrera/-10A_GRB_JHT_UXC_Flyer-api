using MasVeterinarias.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasVeterinarias.Domain.Interfaces
{
    public interface IUserService
    {
        Task AddUser(User user);
        Task DeleteUser(int id);
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task UpdateUser(User user);
    }
}
