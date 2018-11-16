namespace Universe.Days.S
{
    class Day : TheDay
    {
        void Start()
        {

            var mary = new Person();
            mary.Name = "Mary";

            MarysKitchen marysKitchen = new MarysKitchen
            {
                Breakfast = new MarysHealthyBreakfast(),
                Lunch = new MarysLunch()
            };

            mary.Eat(marysKitchen.MakeBreakfast());

            marysKitchen.Breakfast = new MarysNormalBreakfast();

            mary.Eat(marysKitchen.MakeBreakfast());
        }
    }
}