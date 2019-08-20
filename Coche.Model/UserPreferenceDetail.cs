using System;
using System.Collections.Generic;
using System.Text;

namespace Coche.Model
{
    public class UserPreferenceDetail
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PreferenceId { get; set; }
        public bool? IsDeleted { get; set; }
    }

}
