using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare()
        {
            Console.WriteLine("preparing tea");
            return new Tea();
        }
    }
}
