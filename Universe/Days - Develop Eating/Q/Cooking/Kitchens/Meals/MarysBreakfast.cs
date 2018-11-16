namespace Universe.Days.Q
{
    class MarysBreakfast
    {
        public Meal Create()
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
    }
}