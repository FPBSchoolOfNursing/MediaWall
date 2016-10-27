using System;
using System.Collections.Generic;

namespace MediaWall.Models
{
    public partial class Pictures
    {
        public Pictures()
        {
            Alum = new HashSet<Alum>();
            Class = new HashSet<Class>();
        }

        public int Pid { get; set; }
        public DateTime? DisplayYear { get; set; }
        public string ImageLocation { get; set; }
        public string Alt { get; set; }
        public string Filename { get; set; }
        public long? Filesize { get; set; }
        public int? FileWidth { get; set; }
        public int? FileHeight { get; set; }
        public string ThumbnailLocation { get; set; }
        public string ThumbnailAlt { get; set; }
        public string ThumbnailFilename { get; set; }
        public long? ThumbnailSize { get; set; }
        public int? ThumbnailWidth { get; set; }
        public int? ThumbnailHeight { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public string WallLocation { get; set; }
        public string WallAlt { get; set; }
        public string WallFilename { get; set; }
        public long? WallSize { get; set; }
        public int? WallWidth { get; set; }
        public int? WallHeight { get; set; }
        public string WebLocation { get; set; }
        public string WebAlt { get; set; }
        public string WebFilename { get; set; }
        public long? WebSize { get; set; }
        public int? WebWidth { get; set; }
        public int? WebHeight { get; set; }

        public virtual ICollection<Alum> Alum { get; set; }
        public virtual ICollection<Class> Class { get; set; }
    }
}
