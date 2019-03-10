using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mobgo.Models
{
    public class User : Main
    {
        public Guid id { get; set; }

        public String name { get; set; }

        public String email { get; set; }

        public String password { get; set; }

        public virtual ICollection<License> licenses { get; set; }
    }
}