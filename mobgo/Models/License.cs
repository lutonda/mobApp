using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mobgo.Models
{
    public class License
    {
        public Guid id { get; set; }

        public String key { get; set; }

        public User user { get; set; }

        public Pack pack { get; set; }
    }
}