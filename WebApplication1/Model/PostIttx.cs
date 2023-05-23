using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Model
{
    public partial class PostIttx
    {
        public int TxKey { get; set; }
        public int PostSlotId { get; set; }
        public string Email { get; set; }
        public string TransactionCode { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
