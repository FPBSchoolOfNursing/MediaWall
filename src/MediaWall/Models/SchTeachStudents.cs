using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class SchTeachStudents
    {
        public string StudentDmid { get; set; }
        public string Dmid { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }

        public virtual SchTeach Dm { get; set; }
    }
}
