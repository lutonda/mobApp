using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mobgo.Models
{
    public class Sync : Main
    {
        public Guid id { get; set; }

        public Boolean wasSuccessful { get; set; }
    }
}