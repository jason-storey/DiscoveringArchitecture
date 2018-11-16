namespace Universe.Days.Eating.M
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person { Name = "Bob" };

            var morningMeal = new Meal { Type = "Breakfast" };
            morningMeal.Add(new Toast());
            morningMeal.Add(new OrangeJuice());
            person.Eat(morningMeal);

            var eveningMeal = new Meal { Type = "Lunch" };
            eveningMeal.Add(new Sandwich());
            eveningMeal.Add(new Water());
            person.Eat(eveningMeal);
        }
    }
}