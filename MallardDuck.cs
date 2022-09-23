using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            /*
             * A MallardDuck uses the Quack class to handle its quack, so when performQuack() is called,
             * the responsability for the quack is delegated to the Quack object and we get a real quack.
             */
            quackBehavior = new Quack();

            /*
             * And it uses FlyWithWings as its FlyBehavior type.
             */
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}
