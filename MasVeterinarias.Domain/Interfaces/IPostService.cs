using MasVeterinarias.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasVeterinarias.Domain.Interfaces
{

    public interface IPostService
    {
        Task AddPost(Post post);
        Task DeletePost(int id);
        Task<IEnumerable<Post>> GetPosts();
        Task<Post> GetPost(int id);
        Task UpdatePost(Post post);
    }
}
