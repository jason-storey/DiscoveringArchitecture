namespace Universe.Days.Eating.C
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