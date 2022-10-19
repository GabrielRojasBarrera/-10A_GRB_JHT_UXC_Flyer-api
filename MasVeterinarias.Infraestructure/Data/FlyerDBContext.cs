using MasVeterinarias.Domain.Entities;
using MasVeterinarias.Infraestructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace MasVeterinarias.Infraestructure.Data
{

    public partial class FlyerDBContext : DbContext
    {
        public FlyerDBContext()
        {
        }

        public FlyerDBContext(DbContextOptions<FlyerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Follow> Follow { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Like> Like { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            //modelBuilder.ApplyConfiguration<Follow>(new FollowConfiguration());
            //modelBuilder.ApplyConfiguration<Post>(new PostConfiguration());
            //modelBuilder.ApplyConfiguration<Tag>(new TagConfiguration());
            //modelBuilder.ApplyConfiguration<Like>(new LikeConfiguration());
            //modelBuilder.ApplyConfiguration<Comment>(new CommentConfiguration());


        }

    }
}
