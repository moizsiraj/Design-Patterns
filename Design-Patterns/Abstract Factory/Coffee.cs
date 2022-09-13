using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Drinking Coffee");
        }
    }
}
