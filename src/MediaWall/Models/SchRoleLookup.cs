using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class SchRoleLookup
    {
        public SchRoleLookup()
        {
            FacultySchTeach = new HashSet<FacultySchTeach>();
        }

        public string Role { get; set; }

        public virtual ICollection<FacultySchTeach> FacultySchTeach { get; set; }
    }
}
