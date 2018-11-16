namespace Universe.Examples.G
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person();
            person.Name = "Bob";

            var cookie = new Cookie();
            person.Eat(cookie);
            
            var pancake = new Pancake();
            person.Eat(pancake);
        }
    }
}