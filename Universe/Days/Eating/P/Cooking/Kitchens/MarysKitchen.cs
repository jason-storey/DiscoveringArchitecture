namespace Universe.Days.Eating.P
{
    class MarysKitchen : Kitchen
    {
        public override Meal MakeBreakfast()
        {
            var meal = new Meal();
            meal.Name = "Breakfast";
            var toast = new Toast();
            toast.Type = "Jam on";
            meal.Add(toast);

            var juice = new OrangeJuice();
            juice.Type = "Concentrate";

            meal.Add(juice);
            return meal;
        }

        public override Meal MakeLunch()
        {
            var meal = new Meal();
            meal.Name = "Lunch";
            var sandwich = new Sandwich();
            sandwich.Type = "Tuna Melt";
            meal.Add(sandwich);
            meal.Add(new Water());
            return meal;
        }
    }
}