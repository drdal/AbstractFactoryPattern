using System;

namespace AbstractFactoryPattern
{
    public abstract class Pizza
    {
        private String name;

        private Dough dough;

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting {0} into diagonal slices", name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing {0} in a official PizzaStore box", name);
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return this.name;
        }
    }
}