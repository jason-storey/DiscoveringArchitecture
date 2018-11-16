using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Universe
{
    class World
    {
        public void Create()
        {
            var days = GetAllTheDays();
            var groups = days.GroupBy(x => x.Topic).OrderBy(x=>x.Key);

            foreach (var @group in groups)
            {
                StartGroup(@group);
                Console.ReadLine();
                Console.Clear();
            }   
        }

        private void StartGroup(IGrouping<string, IDay> @group)
        {
            Console.WriteLine("GROUP: "+@group.Key);
            
            int count = 1;

            foreach (var day in @group)
            {
                Start(day,count++);
            }

            Console.WriteLine();
        }

        IEnumerable<IDay> GetAllTheDays()
        {
            var interfaceType = typeof(IDay);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(Activator.CreateInstance).Cast<IDay>().OrderBy(x=>x.Dimension);
        }

        void Start(IDay day,int index)
        {
            day.Create(index);

            var m = day.GetType()
               .GetMethod("Start", BindingFlags.NonPublic | BindingFlags.Instance);

            if(m != null)
               m.Invoke(day, new object[] { });
        }
    }
}
