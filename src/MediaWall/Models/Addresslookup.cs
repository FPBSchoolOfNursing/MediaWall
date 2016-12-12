using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Addresslookup
    {
        public Addresslookup()
        {
            Addresses = new HashSet<Addresses>();
        }

        public string AddrType { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
