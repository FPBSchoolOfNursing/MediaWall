using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class PublicationsAuthors
    {
        public int PublicationId { get; set; }
        public int AuthorId { get; set; }
        public string Dmid { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Publications Publication { get; set; }
    }
}
