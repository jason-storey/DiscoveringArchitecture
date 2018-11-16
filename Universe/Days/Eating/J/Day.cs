using System.Collections.Generic;

namespace Universe.Days.Eating.J
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person();
            person.Name = "Bob";

            var breakfast = new List<Food> { new Apple(), new Apple() };
            var lunch = new List<Food> { new Sandwich()};
            var dinner = new List<Food> { new Steak() };
            
            EatMeal(person,breakfast);
            EatMeal(person,lunch);
            EatMeal(person,dinner);
        }

        void EatMeal(Person person, List<Food> meal)
        {
            foreach (var item in meal)
                person.Eat(item);
        }
    }
}