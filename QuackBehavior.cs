using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     *      QuackBehavior is an interface that all quack classes implement.
     *      All new quack classes just need to implement the Quack() method.
     */

    public interface QuackBehavior
    {
        public void Quack();
    }
}
