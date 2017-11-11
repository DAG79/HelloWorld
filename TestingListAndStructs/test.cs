using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingListAndStructs
{
    class test
    {

        private int _x, _y;

        public test(int p1, int p2)
        {
            _x = p1;
            _y = p2;
        }

        public void printout()
        {
            Console.WriteLine(_x + " " + _y);
        }
    }
}
