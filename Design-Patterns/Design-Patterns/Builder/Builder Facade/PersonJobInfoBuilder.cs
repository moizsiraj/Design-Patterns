using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Builder_Facade
{
    internal class PersonJobInfoBuilder : PersonBuilder
    {
        public PersonJobInfoBuilder At(string company) 
        {
            Person.Company = company;
            return this;
        }

        public PersonJobInfoBuilder AsA(string designation) 
        { 
            Person.Designation = designation;
            return this;
        }
    }
}
