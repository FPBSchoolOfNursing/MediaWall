using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Titlelookup
    {
        public Titlelookup()
        {
            TitleNavigation = new HashSet<Title>();
        }

        public string Title { get; set; }
        public bool IsAdminTitle { get; set; }

        public virtual ICollection<Title> TitleNavigation { get; set; }
    }
}
