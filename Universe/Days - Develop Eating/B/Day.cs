namespace Universe.Days.B
{
    class Day : TheDay
    {
        void Start()
        {
            Person person = new Person();
            person.Name = "Bob";
            person.Eat();
        }
    }
}