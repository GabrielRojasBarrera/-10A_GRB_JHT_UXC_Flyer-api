using MasVeterinarias.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasVeterinarias.Domain.Interfaces
{

    public interface IFollowService
    {
        Task AddFollow(Follow follow);
        Task DeleteFollow(int id);
        Task<IEnumerable<Follow>> GetFollows();
        Task<Follow> GetFollow(int id);
        Task UpdateFollow(Follow follow);
    }
}
