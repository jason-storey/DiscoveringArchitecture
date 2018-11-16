namespace Universe.Days.V
{
    class GourmetDogFood : Recipe
    {
        public Meal Create()
        {
            Meal meal = new Meal();
            meal.Add(new Kibble());
            meal.Add(new MeatChunks());
            return meal;
        }
    }
}
