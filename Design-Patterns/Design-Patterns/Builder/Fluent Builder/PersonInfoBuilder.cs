using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Fluent_Builder
{
    internal class PersonInfoBuilder<SELF> where SELF : PersonInfoBuilder<SELF>
    {
        protected Person Person { get; set; }

        public PersonInfoBuilder()
        {
            Person = new();
        }

        public SELF HasName(string name)
        {
            Person.Name = name;
            return (SELF)this;
        }

        public SELF IsOfAge(int age)
        {
            Person.Age = age;
            return (SELF)this;
        }
    }
}
