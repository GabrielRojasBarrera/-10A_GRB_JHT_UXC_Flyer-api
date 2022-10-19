using System;
using System.Collections.Generic;
using System.Text;

namespace MasVeterinarias.Domain.DTOs
{
    public class LikeRequestDto
    {
        public int PostId { get; set; }
        public string UserId { get; set; }
        public int likes { get; set; }
    }
}
