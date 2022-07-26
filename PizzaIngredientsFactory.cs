using System;
namespace AbstractFactoryPattern
{
    public interface PizzaIngredientsFactory
    {
        public Dough CreateDough();

        public Sauce CreateSauce();

        public Cheese CreateCheese();

        public Veggie CreateVeggies();

        public Pepperoni CreatePepperoni();

        public Clam CreateClam();
    }
}

