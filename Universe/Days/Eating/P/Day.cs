namespace Universe.Days.Eating.P
{
    class Day : TheDay
    {
        void Start()
        {
            Person bob = new Person { Name = "Bob" };
            Kitchen bobsKitchen = new BobsKitchen();

            bob.Eat(bobsKitchen.MakeBreakfast());
            bob.Eat(bobsKitchen.MakeLunch());

            var mary = new Person { Name = "Mary" };
            Kitchen marysKitchen = new MarysKitchen();

            mary.Eat(marysKitchen.MakeBreakfast());
            mary.Eat(marysKitchen.MakeLunch());
        }
    }
}