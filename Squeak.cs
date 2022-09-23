using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     *      Here's the implementation of quacks that squeak.
     */

    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
