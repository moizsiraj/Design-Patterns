using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Fluent_Builder
{
    internal class PersonJobInfoBuilder<SELF> : PersonInfoBuilder<PersonJobInfoBuilder<SELF>>
        where SELF : PersonJobInfoBuilder<SELF>
    {
        public SELF WorksAsA(string designation) 
        {
            Person.Designation = designation;
            return (SELF)this;
        }

        public SELF WorksAt(string company)
        {
            Person.Company = company;
            return (SELF)this;
        }
    }
}
