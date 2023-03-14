using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
namespace Task_2_
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<double, string>() 
            {
                [45.50] = "item1",
                [35]    = "item2",
                [41.30] = "item3",
                [55]    = "item4",
                [24]    = "item5"
            };
            var result = dict.OrderByDescending(i => i.Key);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(result.ElementAt(i).Value + " " + result.ElementAt(i).Key);
            }
            string json = JsonSerializer.Serialize<IOrderedEnumerable<KeyValuePair<double,string>>>(result);
            File.WriteAllText("json.json",json);

            Console.ReadKey();
        }
    }
}
