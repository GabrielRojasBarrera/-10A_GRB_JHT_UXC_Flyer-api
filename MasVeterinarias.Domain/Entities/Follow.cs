﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MasVeterinarias.Domain.Entities
{
    public partial class Follow : BaseEntity
    {
        public int UserId { get; set; }
        public string followed { get; set; }



        public virtual User User { get; set; }
    }
}
