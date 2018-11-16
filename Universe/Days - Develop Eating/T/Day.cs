namespace Universe.Days.T
{
    class Day : TheDay
    {
        void Start()
        {

            var mary = new Person();
            mary.Name = "Mary";

            MarysKitchen marysKitchen = new MarysKitchen(new HealthyBreakfast(), new TunaLunch());

            mary.Eat(marysKitchen.MakeBreakfast());

            marysKitchen.SetBreakfastRecipe(new RushBreakfast());

            mary.Eat(marysKitchen.MakeBreakfast());


        }
    }
}