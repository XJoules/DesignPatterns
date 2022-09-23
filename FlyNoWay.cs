using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     *      Here's the implementation for all ducks that can´t fly.
     */

    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
