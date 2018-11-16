namespace Universe.Days.Eating.W
{
    class Day : TheDay
    {
        void Start()
        {
            Wolf wolf = new Wolf();
            Rabbit rabbit = new Rabbit();

            var meat = new Meat();
            var grass = new Grass();
            
            wolf.Eat(meat);
            wolf.Eat(grass);
            rabbit.Eat(meat);
            rabbit.Eat(grass);

        }
    }
}