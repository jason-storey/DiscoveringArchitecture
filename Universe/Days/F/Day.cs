namespace Universe.Examples.F
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person();
            person.Name = "Bob";

            var cookie = new Cookie();

            cookie.Type = "Chocolate Chip";
            person.Eat(cookie);

            cookie.Type = "Raisin";
            person.Eat(cookie);

            cookie.Type = "Bacon";
            person.Eat(cookie);
        }
    }
}