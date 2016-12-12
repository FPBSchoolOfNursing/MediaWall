using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class PresentationsAuthors
    {
        public int PresentationId { get; set; }
        public int AuthorId { get; set; }
        public string Dmid { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Presentations Presentation { get; set; }
    }
}
