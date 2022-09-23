using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     *      Here's the implementation of quacks that really quack.
     */

    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
