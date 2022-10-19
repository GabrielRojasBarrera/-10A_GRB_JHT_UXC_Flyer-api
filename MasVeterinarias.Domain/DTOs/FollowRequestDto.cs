using System;
using System.Collections.Generic;
using System.Text;

namespace MasVeterinarias.Domain.DTOs
{
    public class FollowRequestDto
    {
        public int UserId { get; set; }
        public string followed { get; set; }
    }
}
