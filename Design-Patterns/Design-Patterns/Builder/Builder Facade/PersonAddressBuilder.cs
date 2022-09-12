using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Builder_Facade
{
    internal class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder On(string street) 
        {
            Person.Street = street;
            return this;
        }

        public PersonJobInfoBuilder In(string city) 
        {
            Person.City = city;
            return this;
        }
    }
}
