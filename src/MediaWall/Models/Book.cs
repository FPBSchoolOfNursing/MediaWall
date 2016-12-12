using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Book
    {
        public int PublicationId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Publisher { get; set; }
        public string Chapter { get; set; }
        public string Isbn { get; set; }

        public virtual Publications Publication { get; set; }
    }
}
