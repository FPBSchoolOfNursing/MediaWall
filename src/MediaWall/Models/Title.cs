using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Title
    {
        public string CaseUserId { get; set; }
        public string Title1 { get; set; }
        public bool IsChair { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
        public virtual Titlelookup Title1Navigation { get; set; }
    }
}
