using System;
using System.Collections.Generic;
using System.Text;

namespace MasVeterinarias.Domain.DTOs
{
    public class CommentRequestDto
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string comment { get; set; }
        public DateTime timestamp { get; set; }
    }
}
