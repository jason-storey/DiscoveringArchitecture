namespace Universe.Days.Q
{
    class BobsLunch
    {
        public Meal Create()
        {
            var meal = new Meal();
            meal.Name = "Lunch";
            var sandwich = new Sandwich();
            sandwich.Type = "BLT";
            meal.Add(sandwich);

            var beer = new Beer();
            beer.Type = "Non Alcoholic";

            meal.Add(beer);
            return meal;
        }
    }
}