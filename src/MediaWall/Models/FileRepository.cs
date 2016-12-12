using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class FileRepository
    {
        public int FileId { get; set; }
        public string CaseUserId { get; set; }
        public int? Arptid { get; set; }
        public string FileName { get; set; }
        public string Mimetype { get; set; }
        public int? FileLength { get; set; }
        public byte[] FileBin { get; set; }
        public string Description { get; set; }
        public DateTime? UploadDate { get; set; }
        public string Location { get; set; }

        public virtual Arpt Arpt { get; set; }
        public virtual Faculty CaseUser { get; set; }
    }
}
