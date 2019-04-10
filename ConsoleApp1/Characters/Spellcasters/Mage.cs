
using System;


namespace Characters.Spellcasters
{
    public class Mage : Character
    {
        public Mage(int healhPoints, int weight, int age)
            : base(healhPoints, weight, age) 
        {

        }

        public Mage()
        { }

        public override void Move(int PauseBetweenMovements)
        {
            base.Move(PauseBetweenMovements);
            Console.WriteLine("I just moved 10 times, I am a Mage");
        }

        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 30 && value <= 60)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"Pleae use age between 30 and 60");
                    //Console.WriteLine($@"The warrior {name} is too young to fight");
                }
            }
        }


    }
}
