namespace Universe.Days.T
{
    class MarysKitchen : Kitchen
    {
        public MarysKitchen(Recipe breakfast,Recipe lunch)
        {
            _breakfast = breakfast;
            _lunch = lunch;
        }

        private Recipe _lunch;
        private Recipe _breakfast;

        public void SetBreakfastRecipe(Recipe breakfast) => _breakfast = breakfast;
        public void SetLunchRecipe(Recipe lunch) => _lunch = lunch;

        public override Meal MakeBreakfast() => _breakfast.Create();

        public override Meal MakeLunch() => _lunch.Create();
    }
}