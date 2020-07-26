using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLiteDemoWebApi.Entities
{
    public class Athlete
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
    }
}
