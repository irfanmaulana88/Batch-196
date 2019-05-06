using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRank
{
    class Program
    {
        static void Main(string[] args)
        {

            SimpleArraySum.simpleArraySum(new int[] {1,2,3,4,10,11});
            int jml =SimpleArraySum.simpleArraySum(new int[] { 338, 65, 713, 595, 428, 610, 728, 573, 871, 868 });
            Console.WriteLine(jml);
            Console.ReadKey();

        }
    }
}
