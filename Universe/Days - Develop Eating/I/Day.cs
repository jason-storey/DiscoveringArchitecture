namespace Universe.Days.I
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person();
            person.Name = "Bob";

            var apple = new Apple();
            person.Eat(apple);

            var cookie = new Cookie();
            person.Eat(cookie);

            var donut = new Donut();
            person.Eat(donut);

            var pancake = new Pancake();
            person.Eat(pancake);

            var sandwich = new Sandwich();
            person.Eat(sandwich);

            var steak = new Steak();
            person.Eat(steak);
        }
    }
}