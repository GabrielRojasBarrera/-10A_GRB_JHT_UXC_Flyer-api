using MasVeterinarias.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasVeterinarias.Domain.Interfaces
{
    public interface ILikeService
    {
        Task AddLike(Like like);
        Task DeleteLike(int id);
        Task<IEnumerable<Like>> GetLikes();
        Task<Like> GetLike(int id);
        Task UpdateLike(Like like);
    }
}
