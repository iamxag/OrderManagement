using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class XeroxMachine : IXerox
    {       
        public void print()
        {
            Console.WriteLine("Print");
        }

        public void scan()
        {
            Console.WriteLine("Scan");
        }
    }
}
