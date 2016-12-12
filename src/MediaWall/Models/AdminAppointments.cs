using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class AdminAppointments
    {
        public int AdminTitleId { get; set; }
        public string CaseUserId { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NumHours { get; set; }
        public string TitleDesc { get; set; }
        public string Dmid { get; set; }
        public DateTime? Dmdate { get; set; }

        public virtual Faculty CaseUser { get; set; }
    }
}
