using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class NonTenureFoci
    {
        public string CaseUserId { get; set; }
        public bool Teaching { get; set; }
        public bool Research { get; set; }
        public bool Service { get; set; }

        public virtual Faculty CaseUser { get; set; }
    }
}
