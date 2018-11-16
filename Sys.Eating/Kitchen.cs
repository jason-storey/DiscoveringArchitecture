namespace Sys.Eating
{
    class Kitchen
    {
        public Kitchen(Recipe breakfast,Recipe lunch)
        {
            _breakfast = breakfast;
            _lunch = lunch;
        }

        private Recipe _lunch;
        private Recipe _breakfast;

        public void SetBreakfastRecipe(Recipe breakfast) => _breakfast = breakfast;
        public void SetLunchRecipe(Recipe lunch) => _lunch = lunch;

        public Meal MakeBreakfast() => _breakfast.Create();

        public Meal MakeLunch() => _lunch.Create();
    }
}