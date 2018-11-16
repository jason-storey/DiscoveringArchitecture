
using Sys.Eating;

namespace Universe.Days.Eating.W
{
    class Wolf : Thing, Eater
    {
        public void Eat(Food food)
        {
            if(food.Type.Equals("meat"))
                Act($"Ate {food}");
            else
                Act($"{Name} looked at the {food}, but it only eats meat");
        }

        public void Drink(Drink drink) => 
            Act($"Drank {drink}");
    }
}
