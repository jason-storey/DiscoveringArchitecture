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
            for (int i = days.Count - 1; i >= 0; i--)
            {
                Start(days[i],i+1);
            }
        }

        List<IDay> GetAllTheDays()
        {
            var interfaceType = typeof(IDay);
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(Activator.CreateInstance).Cast<IDay>().OrderBy(x=>x.Dimension).ToList();
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
