using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1_KPI
{
    class Program
    {
        static void Main()
        {
            Stopwatch time = new Stopwatch();
            string name = "Nikita";
            string[] names = new string[]
            {
                "Tom",
                "Jake",
                "Harry",
                "Anna"
            };
            LinkedList<string> peopleLink = new LinkedList<string>(names);
            ArrayList peopleArr = new ArrayList(names);
            SortedSet<string> peopleSort = new SortedSet<string>(names);
            HashSet<string> peopleHash = new HashSet<string>(names);

            time.Start();
            peopleLink.AddLast(name);//00:00:00.0000027
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleArr.Add(name);//00:00:00.0000013
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleSort.Add(name);//00:00:00.0000048
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleHash.Add(name);//00:00:00.0000072
            time.Stop();
            Console.WriteLine(time.Elapsed + "\n\n");

            //////////////////////////////////////////////////
            time.Restart();
            peopleLink.Contains(name);//00:00:00.0000307
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleArr.Contains(name);//00:00:00.0000009
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleSort.Contains(name);//00:00:00.0000064
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleHash.Contains(name);//00:00:00.0000116
            time.Stop();
            Console.WriteLine(time.Elapsed + "\n\n");
            
            ////////////////////////////////////////////
            time.Restart();
            peopleLink.Remove(name);//00:00:00.0000059
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleArr.Remove(name);//00:00:00.0000081
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleSort.Remove(name);//00:00:00.0000062
            time.Stop();
            Console.WriteLine(time.Elapsed);

            time.Restart();
            peopleHash.Remove(name);//00:00:00.0000014
            time.Stop();
            Console.WriteLine(time.Elapsed + "\n\n");

            Console.ReadKey();
        }
    }
}
