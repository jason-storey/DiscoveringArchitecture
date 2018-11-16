namespace Universe.Days.R
{
    class Day : TheDay
    {
        void Start()
        {

            var mary = new Person();
            mary.Name = "Mary";

            MarysKitchen marysKitchen = new MarysKitchen();

            mary.Eat(marysKitchen.MakeBreakfast());

            var meal = marysKitchen.MakeMeal(new RushBreakfast());
            mary.Eat(meal);
            
        }
    }
}