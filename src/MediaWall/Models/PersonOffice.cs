using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class PersonOffice
    {
        public string CaseUserId { get; set; }
        public string OfficeNum { get; set; }

        public virtual Person CaseUser { get; set; }
        public virtual Office OfficeNumNavigation { get; set; }
    }
}
