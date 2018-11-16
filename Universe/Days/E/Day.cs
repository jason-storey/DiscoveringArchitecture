namespace Universe.Examples.E
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person();
            person.Name = "Bob";
            person.Eat("Chocolate Chip");
            person.Eat("Raisin");
        }
    }
}