using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class AdditionalInformation
    {
        public int Aiid { get; set; }
        public int? Arptid { get; set; }
        public string ExtraInfo { get; set; }
        public string GoalAssist { get; set; }
        public string OtherComments { get; set; }

        public virtual Arpt Arpt { get; set; }
    }
}
