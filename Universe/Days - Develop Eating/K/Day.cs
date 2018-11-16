namespace Universe.Days.K
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person {Name = "Bob"};

            var morningMeal = new Meal {Type = "Breakfast"};
            morningMeal.Items.Add(new Toast());
            person.Eat(morningMeal);

            var eveningMeal = new Meal { Type = "Lunch" };
            eveningMeal.Items.Add(new Sandwich());
            person.Eat(eveningMeal);

        }
    }
}