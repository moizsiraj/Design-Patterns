using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Fluent_Builder
{
    internal class PersonAddressBuilder<SELF> : PersonJobInfoBuilder<PersonAddressBuilder<SELF>>
        where SELF : PersonAddressBuilder<SELF>
    {
        public SELF LivesOn(string street) 
        {
            Person.Street = street;
            return (SELF) this;
        }
    }
}
