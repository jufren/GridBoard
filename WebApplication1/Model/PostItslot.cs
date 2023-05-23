using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Model
{
    public partial class PostItslot
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public byte Row { get; set; }
        public byte Col { get; set; }
        public bool Taken { get; set; }
    }
}
