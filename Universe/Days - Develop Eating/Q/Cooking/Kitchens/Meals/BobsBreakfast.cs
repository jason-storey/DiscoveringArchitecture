namespace Universe.Days.Q
{
    class BobsBreakfast
    {
        public Meal Create()
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
    }
}
