using System.Collections.Generic;

namespace Universe.Days.M
{
    class Meal : Thing
    {
       List<Food> Food = new List<Food>();
       List<Drink> Drinks = new List<Drink>();

        public void Eat(Person person)
        {
            foreach (var item in Food)
                person.Eat(item);

            foreach (var item in Drinks)
                person.Drink(item);
        }

        public void Add(Food food) => 
            Food.Add(food);

        public void Add(Drink drink) => 
            Drinks.Add(drink);

    }
}
