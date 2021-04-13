using System;
using System.Collections.Generic;

#nullable disable

namespace LearnAspCore.Models
{
    public partial class Territory
    {
        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
    }
}
