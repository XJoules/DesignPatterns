using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Duck
    {
        /*
         * The behavior variables are declared as the behavior INTERFACE type.
         * Instance variables hold a reference to a specific behavior at runtime.
         * 
         * Each duck has a reference to something that implements the QuackBehavior interface.
         * Rather than handling the quack behavior itself, the Duck object delegates that behavior to the object referenced by quackBehavior.
         */ 

        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;
        
        public abstract void Display();
        
        //This method replace fly()
        public void PerformFly()
        {
            //Delegate to the behavior class.
            flyBehavior.Fly();
        }

        //This method replace quack()
        public void PerformQuack()
        {
            //Delegate to the behavior class.
            quackBehavior.Quack();
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
