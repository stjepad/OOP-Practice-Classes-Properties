using System;


namespace Characters.Warriors

{
    public class Warrior
    {
        private int height;
        private int weight;
        private string name;
        private int age;


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
                    //Why this not work?
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

        //constructor
        public Warrior(int height, int weight, string name)
        {
            Height = height;
            Weight = weight;
            Name = name;

        }

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($@"Hello, {warrior.Name}!");
        }
    }
}

