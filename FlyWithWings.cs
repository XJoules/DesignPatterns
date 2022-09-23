using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     *      Here's the implementation of flying for all ducks that have wings.
     */

    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
