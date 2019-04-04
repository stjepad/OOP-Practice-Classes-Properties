
using ConsoleApp1.Weapons;
using System;


namespace Characters.Warriors

{
    public class Warrior
    {
        private int height;
        private int weight;
        private string name;
        private int age;

        private Sword swordWeapon;

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
        public int Weight { get; set; }
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
                return name;
            }
            set
            {
                name = value;
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
            : this(200, 200)
        {
            //this.Height = 200;
            //this.Weight = 200;
            //this.Name = "Young Warriorr";
            //this.Age = 18;
            //this.SwordWeapon = new Sword();
        }

    // constructor
    public Warrior( int height, int weight)
            : this(height, weight, "Youngin Fighter")
        {
            //Height = height;
            //Weight = weight;
            //this.Name = "Young Warriorr";
            //this.Age = 18;
            //this.SwordWeapon = new Sword();
        }
        //constructor
        public Warrior(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;
            this.Age = 18;
            this.SwordWeapon = new Sword();
        }


        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($@"Hello, {warrior.Name}!");
        }
    }
    }




