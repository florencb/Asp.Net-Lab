using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.Models
{
    public class Trip
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string CreatedDate { get; set; }
        public string UserName { get; set; }
        public string Stops { get; set; }
    }
}
