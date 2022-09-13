using Design_Patterns.Builder.Fluent_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Street { get; set; }
        public string City { get; set; }    
        public string Designation { get; set; }
        public string Company { get; set; }
        public long Salary { get; set; }

        public static PersonBuilder New => new PersonBuilder();
    }
}
