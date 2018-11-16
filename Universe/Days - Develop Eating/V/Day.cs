namespace Universe.Days.V
{
    class Day : TheDay
    {
        void Start()
        {
            var mary = new Person();
            mary.Name = "Mary";

            var marysKitchen = new Kitchen(new HealthyBreakfast(), new TunaLunch());
            mary.Eat(marysKitchen.MakeBreakfast());

            var bob = new Person();
            bob.Name = "Bob";

            Kitchen bobsKitchen = new Kitchen(new RushBreakfast(), new ToastJamAndOrangeJuice());
            bob.Eat(bobsKitchen.MakeBreakfast());

            Kitchen petshopKitchen = new Kitchen(new GourmetDogFood(),new DogTreat());

            var marysDog = new Dog();
            marysDog.Type = "Mary's";
            marysDog.Name = "Rover";

            var roversBreakfast = petshopKitchen.MakeBreakfast();
            marysDog.Eat(roversBreakfast);

        }
    }
}