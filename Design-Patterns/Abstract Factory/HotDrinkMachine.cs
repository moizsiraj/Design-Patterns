using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory
{
    public class HotDrinkMachine
    {
        internal enum Drinks
        {
            Coffee,
            Tea,
        }

        Dictionary<Drinks, IHotDrinkFactory> factories;

        public static HotDrinkMachine GetMachine(bool buildFactoryExplicitly) 
        {
            if (buildFactoryExplicitly)
                return new HotDrinkMachine();
            else
                return BuildImplicitly();
        }

        private static HotDrinkMachine BuildImplicitly()
        {
            Dictionary<Drinks, IHotDrinkFactory> factories = new();
            foreach (Drinks drink in Enum.GetValues(typeof(Drinks))) 
            {
                var factory = Activator.CreateInstance(Type.GetType("Design_Patterns.Abstract_Factory." + Enum.GetName(typeof(Drinks), drink) + "Factory"));
                factories.Add(drink, (IHotDrinkFactory)factory);
            }
            return new HotDrinkMachine(factories);
        }

        internal HotDrinkMachine(Dictionary<Drinks, IHotDrinkFactory> factory)
        {
            factories = factory;
        }

        public HotDrinkMachine()
        {
            factories = new();
            factories.Add(Drinks.Tea, new TeaFactory());
            factories.Add(Drinks.Coffee, new CoffeeFactory());
        }

        internal void GetDrink(Drinks drinks) 
        {
            factories.TryGetValue(drinks, out IHotDrinkFactory factory);
            if (factory is not null) 
            {
                var drink = factory.Prepare();
                drink.Consume();
            }
        }
    }
}
