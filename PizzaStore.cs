using System;
namespace AbstractFactoryPattern
{
    public abstract class PizzaStore
    {
        public PizzaStore()
        {
        }

        public Pizza OrderPizza(String type)
        {
            Pizza pizza;

            // Call for Abstract method
            // This Creator class has no idea which Concrete subclass will create the actual pizza
            // It's decoupled
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }
    }
}

