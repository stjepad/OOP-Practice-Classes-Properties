
using ConsoleApp1.Weapons;
using Enumerations;
using System;


namespace Characters.Warriors

{
    public class Warrior
    {
        private const int DEFUALT_HEIGHT = 200;
        private const int DEFAULT_WEIGHT = 200;
        private const string DEFAULT_NAME = "Youngin Fighter";
        private const int DEFAULT_AGE = 18;
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        public static int idCounter;

        private readonly int id;
        private int height;
        private int weight;
        private string name;
        private int age;
        private Faction faction;
        private int healthPoints;

        private Sword swordWeapon;

        // Properties 

            public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                healthPoints = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            private set
            {
                this.faction = value;
            }
        }
        public int ID
        {
            get
            {
                return this.id;
            }
            //no set value, because it was declared as a readonly.
        }
        
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public int Age
        {
            get
            {
                
                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The warrior {name} is too young to fight");
                    //Console.WriteLine($@"The warrior {name} is too young to fight");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        //Empty default constructor. Advised to always have it. No initial values. No arguements.
        //public Warrior ()
        //{

        //}

        //constructor
        public Warrior()
            // ': this' gives all constructors in this same class the folowing as default.
            : this(DEFUALT_HEIGHT, DEFAULT_WEIGHT)
        {
            //this.Height = 200;
            //this.Weight = 200;
            //this.Name = "Young Warriorr";
            //this.Age = 18;
            //this.SwordWeapon = new Sword();
        }

    // constructor
    public Warrior( int height, int weight)
            : this(height, weight, DEFAULT_NAME, Faction.Default)
        {
            //Height = height;
            //Weight = weight;
            //this.Name = "Young Warriorr";
            //this.Age = 18;
            //this.SwordWeapon = new Sword();
        }
        //constructor
        public Warrior(int height, int weight, string name, Faction faction)
        {
            Warrior.idCounter++;

            this.id = idCounter;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = DEFAULT_AGE;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;
            this.Faction = faction;

            if(this.Faction == Faction.GoodGuy)
            {
                this.HealthPoints = 120;
            }
            else if (this.Faction == Faction.BadGuy)
            {
                this.HealthPoints = 100;
            }
        }

        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($@"Default Height: {DEFUALT_HEIGHT} " +
                $"\nDefault Weight: {DEFAULT_WEIGHT} " +
                $"\nDefault Name: {DEFAULT_NAME} " +
                $"\nDefault Age: {DEFAULT_AGE} " +
                $"\nDedault Weapon Damage: {warrior.DEFAULT_SWORD_WEAPON.Damage}");
        }

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($"Hello, {warrior.Name}!");
        }
    }

     
    }




