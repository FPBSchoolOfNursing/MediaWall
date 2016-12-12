using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class PersonCredentials
    {
        public int Cid { get; set; }
        public string CaseUserId { get; set; }
        public string Acronym { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime? CredentialExpDate { get; set; }
        public int? ListingOrder { get; set; }
        public DateTime? AcquireDate { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Credentialslookup AcronymNavigation { get; set; }
        public virtual Person CaseUser { get; set; }
    }
}
