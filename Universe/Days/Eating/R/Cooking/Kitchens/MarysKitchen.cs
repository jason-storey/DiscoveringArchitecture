namespace Universe.Days.Eating.R
{
    class MarysKitchen : Kitchen
    {
        public override Meal MakeBreakfast() => 
            new ToastJamAndOrangeJuice().Create();

        public Meal MakeMeal(Recipe recipe) =>
            recipe.Create();

        public override Meal MakeLunch() => 
            new TunaLunch().Create();
    }
}