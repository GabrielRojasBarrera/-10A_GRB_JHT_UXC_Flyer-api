﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MasVeterinarias.Domain.Entities
{
    public partial class Like : BaseEntity
    {
        public int PostId { get; set; }
        public string UserId { get; set; }
        public int likes { get; set; }
       



        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
   
}
