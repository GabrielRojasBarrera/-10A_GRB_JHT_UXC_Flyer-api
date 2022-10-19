using MasVeterinarias.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace MasVeterinarias.Domain.Interfaces
{
    public  interface IUnitOfWork : IDisposable
    {
        public IRepository<User> UserRepository { get; }       
        public IRepository<Tag> TagRepository { get; }
        public IRepository<Like> LikeRepository { get; }
        public IRepository<Follow> FollowRepository { get; }
        public IRepository<Comment> CommentRepository { get; }
        public IRepository<Post> PostRepository { get; }
       
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
