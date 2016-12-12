using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class CandidacyCommittees
    {
        public int Cid { get; set; }
        public int? Arptid { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public bool? IsChair { get; set; }
        public bool? IsMember { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
