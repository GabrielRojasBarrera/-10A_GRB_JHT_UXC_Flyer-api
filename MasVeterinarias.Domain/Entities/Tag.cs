using System;
using System.Collections.Generic;
using System.Text;

namespace MasVeterinarias.Domain.Entities
{
    public partial class Tag : BaseEntity

    {
        public Tag()
        {
            Post = new HashSet<Post>();
        }


        public string Name { get; set; }


        public virtual ICollection<Post> Post { get; set; }
    }
}
