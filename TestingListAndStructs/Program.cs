using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingListAndStructs
{
    class Program
    {

        static void Main(string[] args)
        {

            // Initialise:   
            test coords1 = new test(0,0);
            test coords2 = new test(10, 10);

            List<test> list = new List<test>();
            list.Add(coords1);
            list.Add(coords2);

            // Display results:

            foreach (test obj in list)
            {
                obj.printout();
            }

            //Needed to make some changes to commit
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}

