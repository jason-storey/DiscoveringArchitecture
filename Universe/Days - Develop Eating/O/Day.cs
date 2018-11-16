namespace Universe.Days.O
{
    class Day : TheDay
    {
        void Start()
        {
            Person bob = new Person { Name = "Bob" };
            Kitchen bobsKitchen = new Kitchen();

            bob.Eat(bobsKitchen.MakeBreakfast());
            bob.Eat(bobsKitchen.MakeLunch());

            var mary = new Person { Name = "Mary" };
            Kitchen marysKitchen = new Kitchen();

            mary.Eat(marysKitchen.MakeBreakfast());
            mary.Eat(marysKitchen.MakeLunch());
        }
    }
}