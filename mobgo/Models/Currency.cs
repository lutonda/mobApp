using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mobgo.Models
{
    public class Currency : Main
    {
        public Guid id { get; set; }

        public float value { get; set; }

        public String name { get; set; }

        public String symbol { get; set; }

        public String country { get; set; }

    }
}