namespace Universe.Days.S
{
    class MarysKitchen : Kitchen
    {
        public Recipe Breakfast;
        public Recipe Lunch;

        public override Meal MakeBreakfast() => 
            MakeMeal(Breakfast);

        public override Meal MakeLunch() =>
            MakeMeal(Lunch);

        public Meal MakeMeal(Recipe recipe) =>
            recipe.Create();
    }
}