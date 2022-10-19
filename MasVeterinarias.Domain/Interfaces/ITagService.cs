using MasVeterinarias.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasVeterinarias.Domain.Interfaces
{

    public interface ITagService
    {
        Task AddTag(Tag tag);
        Task DeleteTag(int id);
        Task<IEnumerable<Tag>> GetTags();
        Task<Tag> GetTag(int id);
        Task UpdateTag(Tag tag);
    }
}
