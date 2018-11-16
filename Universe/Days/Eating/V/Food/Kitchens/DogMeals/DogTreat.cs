namespace Universe.Days.Eating.V
{
    class DogTreat : Recipe
    {
        public Meal Create()
        {
            Meal meal = new Meal();
            meal.Add(new Bone());
            meal.Add(new ButcherLeftovers());
            return meal;
        }
    }
}