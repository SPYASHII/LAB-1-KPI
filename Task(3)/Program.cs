using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_
{
    class Program
    {
        static void Main()
        {
            List<int> sequence = new List<int> (){-5,-2,1,2,3,-2,1,-4,10,-60,8,7,5};

            //var selectedPosNum = from n in sequence where Math.Sign(n).Equals(1) select n;
            //var selectedNegNum = from n in sequence where Math.Sign(n).Equals(-1) select n;
            //Console.WriteLine(selectedPosNum.First() + " " + selectedNegNum.Last());

            //Console.WriteLine(sequence.FirstOrDefault(n => Math.Sign(n).Equals(1)) + " " + sequence.LastOrDefault(n => Math.Sign(n).Equals(-1)));

            Console.WriteLine(sequence.FirstOrDefault(n => n > 0) + " " + sequence.LastOrDefault(n => n < 0));
            Console.ReadKey();
        }
    }
}
