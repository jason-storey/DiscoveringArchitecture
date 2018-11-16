namespace Universe.Days.N
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person { Name = "Bob" };

            Kitchen kitchen = new Kitchen();

            person.Eat(kitchen.MakeBreakfast());
            person.Eat(kitchen.MakeLunch());
        }
    }
}