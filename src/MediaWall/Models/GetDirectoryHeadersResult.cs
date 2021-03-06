﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaWall.Models
{
    public class GetDirectoryHeadersResult
    {
        [Key]
        public string CaseUserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string OfficeNum { get; set; }
        public string Email { get; set; }
        public string PersonType { get; set; }
    }
}
