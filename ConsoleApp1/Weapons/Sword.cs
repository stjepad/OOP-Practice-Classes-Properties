using System;

namespace ConsoleApp1.Weapons
{
    public class Sword
    {
        private int damage;
        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                this.damage = value;
            }
        }

            public Sword ()
            {
                this.Damage = 10;
            }
        
    }
}

