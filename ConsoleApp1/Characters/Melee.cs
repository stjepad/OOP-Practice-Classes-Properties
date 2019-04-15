using Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Characters
{
    public abstract class Melee : Character
    {
        public Melee()
        {

        }
        public Melee(int healthPoints, int weight, int age)
            // : base() works like a : this() but rather than chaining, it provides a connection to a constructor from a parent inheritance class.
            : base(healthPoints,weight,age)
        {

        }
    }
}
