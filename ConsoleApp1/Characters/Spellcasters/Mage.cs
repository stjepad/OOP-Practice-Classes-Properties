
using ConsoleApp1.Characters.Spellcasters;
using Interfaces;
using System;
using Characters.Warriors;
using ConsoleApp1.Weapons;

namespace Characters.Spellcasters
{
    public class Mage : Character, ISpellcaster, ICalculator
    {
        private int mana;
        private Spell mySpell;

        public Mage(int healhPoints, int weight, int age)
            : base(healhPoints, weight, age) 
        {
            
        }

        public Mage()
        {
            this.Mana = 100;
            this.MySpell = new Spell();
        }



        public override void Move(int PauseBetweenMovements)
        {
            base.Move(PauseBetweenMovements);
            Console.WriteLine("I just moved 10 times, I am a Mage");
        }

        public override void Addition(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            int modifiedSum = sum + 123;
            Console.WriteLine(modifiedSum - 200);
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

        public void CastSpell(Character character)
        {
            character.HealthPoints = character.HealthPoints - this.mySpell.Damage;
            this.mana = this.mana - this.mySpell.ManaCost;
        }

        

        public int Mana
        {
            get
            {
                return this.mana;
            }
            set
            {
                this.mana = value;
            }
        }
        public Spell MySpell
        {
            get
            {
                return this.mySpell;
            }
            set
            {
                this.mySpell = value;
            }
        }
    }
}
