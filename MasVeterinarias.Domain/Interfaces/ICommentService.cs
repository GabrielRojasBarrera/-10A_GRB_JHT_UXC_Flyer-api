using MasVeterinarias.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasVeterinarias.Domain.Interfaces
{
    public interface ICommentService
    {
        Task AddComment(Comment comment);
        Task DeleteComment(int id);
        Task<IEnumerable<Comment>> GetComments();
        Task<Comment> GetComment(int id);
        Task UpdateComment(Comment comment);
    }
}
