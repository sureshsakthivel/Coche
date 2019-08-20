using System;
using System.Collections.Generic;
using System.Text;

namespace Coche.Model
{
    public class PreferenceGroupMaster
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class PreferenceMaster
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public string Description { get; set; }
        public Guid PreferenceGroupId { get; set; }
    }

    public class RatingMaster
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; }
        public int Value { get; set; }
    }


}
