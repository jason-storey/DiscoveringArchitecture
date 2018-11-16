using System;

namespace Universe
{
    interface IDay
    {
        void Create(int index);
        string Dimension { get; }
    }

    abstract class TheDay : Thing,IDay
    {
        public void Create(int index)
        {
            //Name = NameWithDimension;
            WriteLine("***************", ConsoleColor.Black);
            Act(index.ToString(),ConsoleColor.DarkGreen,0);
            WriteLine("***************",ConsoleColor.DarkGray);
        }

        public string Dimension => NameWithDimension.Remove(NameWithDimension.Length-Type.Length);

        string NameWithDimension => GetType().FullName.Substring("Universe.Examples.".Length);
    }
}
