using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Addresses
    {
        public int AddrId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int? Plus4 { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public bool? IsMailable { get; set; }
        public string CaseUserId { get; set; }
        public string AddrType { get; set; }
        public DateTime? Dmdate { get; set; }
        public string Dmid { get; set; }

        public virtual Addresslookup AddrTypeNavigation { get; set; }
        public virtual Person CaseUser { get; set; }
    }
}
