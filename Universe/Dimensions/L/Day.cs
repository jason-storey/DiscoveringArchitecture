namespace Universe.Examples.L
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person { Name = "Bob" };

            var morningMeal = new Meal { Type = "Breakfast" };
            morningMeal.Food.Add(new Toast());
            morningMeal.Drinks.Add(new OrangeJuice());
            person.Eat(morningMeal);

            var eveningMeal = new Meal { Type = "Lunch" };
            eveningMeal.Food.Add(new Sandwich());
            eveningMeal.Drinks.Add(new Water());
            person.Eat(eveningMeal);
        }
    }
}