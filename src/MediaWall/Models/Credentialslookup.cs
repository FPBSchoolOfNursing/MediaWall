using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Credentialslookup
    {
        public Credentialslookup()
        {
            PersonCredentials = new HashSet<PersonCredentials>();
        }

        public string Acronym { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PersonCredentials> PersonCredentials { get; set; }
    }
}
