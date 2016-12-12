using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Noncreditinstructionlookup
    {
        public Noncreditinstructionlookup()
        {
            NonCreditInstruction = new HashSet<NonCreditInstruction>();
        }

        public string InstructionType { get; set; }

        public virtual ICollection<NonCreditInstruction> NonCreditInstruction { get; set; }
    }
}
