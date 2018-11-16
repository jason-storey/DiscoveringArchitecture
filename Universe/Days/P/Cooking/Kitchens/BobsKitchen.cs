namespace Universe.Examples.P
{
    class BobsKitchen : Kitchen
    {
        public override Meal MakeBreakfast()
        {
            var meal = new Meal();
            meal.Name = "Breakfast";
            var toast = new Toast();
            toast.Type = "Lightly Buttered";
            meal.Add(toast);

            var juice = new OrangeJuice();
            juice.Type = "Fresh";
            
            meal.Add(juice);
            return meal;
        }

        public override Meal MakeLunch()
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