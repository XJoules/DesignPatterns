using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     *      Here's the implementation of quacks that make no sound at all.
     */
    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
