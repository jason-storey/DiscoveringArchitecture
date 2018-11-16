using Sys.Eating;

namespace Universe.Days.Eating.W
{
    class Rabbit : Thing, Eater
    {
        public void Eat(Food food)
        {
            if (!food.Type.Equals("meat"))
                Act($"Ate {food}");
            else
                Act($"{Name} looked at the {food}, but it does not eat meat");
        }

        public void Drink(Drink drink) => 
            Act($"Drank {drink}");
    }
}