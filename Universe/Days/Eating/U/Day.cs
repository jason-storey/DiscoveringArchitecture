namespace Universe.Days.Eating.U
{
    class Day : TheDay
    {
        void Start()
        {
            var mary = new Person();
            mary.Name = "Mary";

            Kitchen marysKitchen = new HomeKitchen(new HealthyBreakfast(), new TunaLunch());
            mary.Eat(marysKitchen.MakeBreakfast());

            var bob = new Person();
            bob.Name = "Bob";

            Kitchen bobsKitchen = new HomeKitchen(new RushBreakfast(), new ToastJamAndOrangeJuice());
            bob.Eat(bobsKitchen.MakeBreakfast());
        }
    }
}