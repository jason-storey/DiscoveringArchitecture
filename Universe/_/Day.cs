using System;

namespace Universe
{
    interface IDay
    {
        void Create(int index);
        string Dimension { get; }
        string Topic { get; }
    }

    abstract class TheDay : Thing,IDay
    {
        protected TheDay()
        {
            var fullnamespace = GetType().FullName; //Universe.Days.Eating.B
            var parts = fullnamespace.Split('.');
            Topic = parts[2];
            Dimension = parts[3];
        }

        public void Create(int index)
        {
            WriteLine("***************", ConsoleColor.Black);
            Act(index.ToString(),ConsoleColor.DarkGreen,0);
            WriteLine("***************",ConsoleColor.DarkGray);
        }

        public string Dimension { get; }
        public string Topic { get; }
        
    }
}
