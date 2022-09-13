using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Builder_Facade
{
    internal class PersonBuilder
    {
        protected Person Person { get; set; }

        public PersonJobInfoBuilder Works { get; }

        public PersonAddressBuilder Lives { get;  }

        public PersonBuilder()
        {
            Person = new();
            Works = new PersonJobInfoBuilder();
            Lives = new PersonAddressBuilder();
        }
    }
}
