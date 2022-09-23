using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*
     *      FlyBehavior is an interface that all flying classes implement.
     *      All new flying classes just need to implement the Fly() method.
     */

    public interface FlyBehavior
    {
        public void Fly();
    }
}
